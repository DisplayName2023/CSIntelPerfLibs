using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSIntel.Ipp
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IppComplex
    {
        public double Real;
        public double Imaginary;
    }
}
