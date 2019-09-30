using System;
using BookTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BogTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Bog bog = new Bog();

            bog.Titel = "ja";

            Assert.AreEqual("ja", bog.Titel);

            try
            {
                bog.Titel = "j";
                Assert.Fail();
            }
            catch (ArgumentException e)
            {
               
            }
        }

        [TestMethod]
        public void TestSidetal()
        {
            Bog bog = new Bog();
            bog.Sidetal = 10;
            Assert.AreEqual(10, bog.Sidetal);

            bog.Sidetal = 1000;
            Assert.AreEqual(1000, bog.Sidetal);

            try
            {
                bog.Sidetal = 9;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {
                
            }

            try
            {
                bog.Sidetal = 1001;
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException e)
            {

            }
        }
         
        [TestMethod]
        public void TestIsbn()
        {
            Bog bog = new Bog();
            bog.Isbn = "1234567890123";
            Assert.AreEqual("1234567890123", bog.Isbn);

            try
            {
                bog.Isbn = "123456789012";
                Assert.Fail();
            }
            catch (ArgumentException e)
            {

            }

            try
            {
                bog.Isbn = "1";
                Assert.Fail();
            }
            catch (ArgumentException e)
            {

            }
        }
    }
}
