using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using PageOrientedFramework.Base;

namespace IBS2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new ChromeDriver();

        }
    }
}
