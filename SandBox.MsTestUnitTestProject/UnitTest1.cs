using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace SandBox.MsTestUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        private static TestContext _testContext;

        [ClassInitialize]
        public static void SetupTests(TestContext testContext)
        {
            _testContext = testContext;
        }

        [TestMethod]
        public void TestMethod1()
        {
            foreach (DictionaryEntry de in TestContext.Properties)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

            //bool environmentVariableExtractionSuccess = context.Properties.["environment"];

            //if (!environmentVariableExtractionSuccess)
            //{
            //    throw new Exception("Cannot proceed with testing because the environment variable has not been provided.");
            //}

            Console.WriteLine("hi");
        }
    }
}
