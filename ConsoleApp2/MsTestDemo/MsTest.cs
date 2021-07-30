using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MsTestDemo
{
    [TestClass]
    public class MsTest1
    {
        /*
        [AssemblyInitialize]
        public void assemblyIni()
        {
            Console.WriteLine("ASsembly init");
        }
        [AssemblyCleanup]
        public void AssemblyCleanup()
        {
            Console.WriteLine("ASsembly cleanup");
        }*/
        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("Test init");
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Console.WriteLine("Test Cleanup");
        }
        [TestMethod]
        public void M1()
        {
            Console.WriteLine("Test method1");

        }
        [TestMethod]
        public void M2()
        {
            Console.WriteLine("Test method2");

        }
    }
}
