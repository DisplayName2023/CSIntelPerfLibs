

$scriptDir = $PSScriptRoot
$currentDir = Get-Location
Set-Location $scriptDir

$nuget = "$scriptDir\Nuget.exe"

$solutionDir = "$scriptDir\.."

# Get the content of the version.cs file
$content = Get-Content -Path "${solutionDir}\CSIntel.Ipp\Properties\AssemblyInfo.cs"
# Find the line that contains the assembly version attribute
$line = $content | Where-Object { $_ -match '\[assembly: AssemblyVersion\("(.*)"\)\]' }
# Extract the version text from the line using a regular expression
$version = $line -replace '\[assembly: AssemblyVersion\("(.*)"\)\]', '$1'
# Print the version text
Write-Output "Version: $version"


$package = "$scriptDir\..\Package.nuspec"
if ((Test-Path $package) -eq $true)
{
    Remove-Item -Path "$scriptDir\*.nupkg" -Force
    
    & $nuget pack $package     
    $nupkgFile = Get-ChildItem -Path "$scriptDir\*.nupkg"    
} else {

    $ippReleaseDir = "$scriptDir\..\CSIntel.Ipp\bin\Release"
    Remove-Item -Path $ippReleaseDir\*.nupkg -Force
    & dotnet pack "$scriptDir\..\CSIntel.Ipp\CSIntel.Ipp.NET.csproj" --configuration Release -p:Version=$version
    $nupkgFile = Get-ChildItem -Path "$ippReleaseDir\*.nupkg"    
}



& $nuget push $nupkgFile -Source https://api.nuget.org/v3/index.json -ApiKey $env:NUGET_ORG_API_KEY

Set-Location $currentDir