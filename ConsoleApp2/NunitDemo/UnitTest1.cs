using NUnit.Framework;

namespace NunitDemo
{
    [TestFixture]//Test class
    public class Tests
    {
        [OneTimeSetUp]//Assembly initialize
        public void OneTimeSetup()
        {

        }
        [OneTimeTearDown]//Assembly cleaup
        public void OneTimeTeardown()
        {

        }

        [SetUp]//TestInitialize
        public void Setup()
        {
        }
        [TearDown]//TestCleanup
        public void TeatDown()
        {
        }


        [Test]//TestMethod
        public void Test1()
        {
           
        }
    }
}