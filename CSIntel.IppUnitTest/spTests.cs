using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSIntel.Ipp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSIntel.Ipp;
using System.Runtime.InteropServices;

namespace CSIntel.Ipp.Tests
{
    [TestClass()]
    public class spTests
    {
        [TestMethod()]
        public unsafe void ippsRandGauss_64fTest()
        {

            const int length = 10;     // Length of the random number sequence

            int randGaussStateSize;
            sp.ippsRandGaussGetSize_64f(out randGaussStateSize);


            IppsRandGaussState_64f* randGaussState = (IppsRandGaussState_64f*)sp.ippsMalloc_64f(randGaussStateSize);

            // Initialize the random number generator
            IppStatus status = sp.ippsRandGaussInit_64f(randGaussState, 1, 1, 123456);

            double* randNumbersPtr = sp.ippsMalloc_64f(length);

            if (status == IppStatus.ippStsNoErr)
            {
                // Generate Gaussian-distributed random numbers
                status = sp.ippsRandGauss_64f(randNumbersPtr, length, randGaussState);

                if (status == IppStatus.ippStsNoErr)
                {
                    // Print the generated random numbers
                    Console.WriteLine("Generated random numbers:");
                    double[] randNumbers = new double[length];
                    for (int i = 0; i < randNumbers.Length; i++)
                    {
                        randNumbers[i] = randNumbersPtr[i];
                    }
                    foreach (var number in randNumbers)
                    {
                        Console.WriteLine(number);
                    }
                }
                else
                {
                    Console.WriteLine("Error generating random numbers: " + status);
                }
            }
            else
            {
                Console.WriteLine("Error initializing random number generator: " + status);
            }

            // Free allocated memory
            sp.ippsFree(randNumbersPtr);
            sp.ippsFree(randGaussState);
        }
    }
}