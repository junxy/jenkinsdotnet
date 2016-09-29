using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JenkinsDotNet.Tests
{

    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestExamples()
        {
            Assert.AreEqual(100, 100);
        }

    }
}
