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



        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern IppStatus ippsFree(void* p);


        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern byte* ippsMalloc_8u(int len);


        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern ushort* ippsMalloc_16u(int len);


        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern uint* ippsMalloc_32u(int len);


        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern short* ippsMalloc_16s(int len);


        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern int* ippsMalloc_32s(int len);


        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern Int64* ippsMalloc_64s(int len);



        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern float* ippsMalloc_32f(int len);

        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern double* ippsMalloc_64f(int len);


        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern IppComplexF* ippsMalloc_32fc(int len);


        [SuppressUnmanagedCodeSecurity()]
        [DllImport(libname)]
        public static extern IppComplex* ippsMalloc_64fc(int len);







        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern IppStatus ippsDFTGetSize_C_64fc(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);




        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern IppStatus ippsDFTInit_C_64fc(int length, int flag, IppHintAlgorithm hint, IppsDFTSpec_C_64fc* pDFTSpec, byte* pMemInit);



        [SuppressUnmanagedCodeSecurityAttribute()]
        [DllImport(libname)]
        public static extern IppStatus ippsFIRMRGetSize(int tapsLen, int upFactor, int downFactor, IppDataType tapsType, int* pSpecSize, int* pBufSize);








    }

}

