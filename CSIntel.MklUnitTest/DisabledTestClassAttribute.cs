using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIntel.MklUnitTest.NET
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class DisabledTestClassAttribute : Attribute
    {
    }
}
