

$scriptDir = $PSScriptRoot
$currentDir = Get-Location
Set-Location $scriptDir

$nuget = "$scriptDir\Nuget.exe"


$package = "$scriptDir\..\Package.nuspec"
if ((Test-Path $package) -eq $true)
{
    Remove-Item -Path "$scriptDir\*.nupkg" -Force
    
    & $nuget pack $package     
    $nupkgFile = Get-ChildItem -Path "$scriptDir\*.nupkg"    
} else {

    $ippReleaseDir = "$scriptDir\..\CSIntel.Ipp\bin\Release"
    Remove-Item -Path $ippReleaseDir\*.nupkg -Force
    & dotnet pack "$scriptDir\..\CSIntel.Ipp\CSIntel.Ipp.NET.csproj" --configuration=Release
    $nupkgFile = Get-ChildItem -Path "$ippReleaseDir\*.nupkg"    
}



& $nuget push $nupkgFile -Source https://api.nuget.org/v3/index.json -ApiKey $env:NUGET_ORG_API_KEY

Set-Location $currentDir