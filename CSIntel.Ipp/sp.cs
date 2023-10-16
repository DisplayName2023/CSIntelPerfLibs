using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;


namespace CSIntel.Ipp
{

    unsafe public partial class sp
    {


        public const int IPP_FFT_DIV_FWD_BY_N = 1;
        public const int IPP_FFT_DIV_INV_BY_N = 2;
        public const int IPP_FFT_DIV_BY_SQRTN = 4;
        public const int IPP_FFT_NODIV_BY_ANY = 8;


        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern IppStatus ippsFree(void* p);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern IppStatus ippsDFTGetSize_C_64fc(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);


        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern byte* ippsMalloc_8u(int len);

        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern IppStatus ippsDFTInit_C_64fc(int length, int flag, IppHintAlgorithm hint, IppsDFTSpec_C_64fc* pDFTSpec, byte* pMemInit);

    }

}

