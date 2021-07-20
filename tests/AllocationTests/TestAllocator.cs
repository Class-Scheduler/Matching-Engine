using System;
using Class_Scheduler.Models;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Scheduler.Controllers.FileIOControllers;

namespace Class_Scheduler.Tests.ParseTests
{
    [TestClass]
    public class TestAllocator
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void Test()
        {
            string staffFilePath = (string) TestContext.Properties["staffFile"];
            string unitsFilePath = (string) TestContext.Properties["unitsFile"];
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

        }
    }
}