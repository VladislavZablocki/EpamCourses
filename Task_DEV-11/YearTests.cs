using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_6;

namespace task_DEV_6Tests
{
    [TestClass]
    public class YearTests
    {
        [TestMethod]
        public void GetInFormat_Formaty_Year()
        {
            DateTime today = DateTime.Now;
            string actualYear = today.ToString("%y");

            Year year = new Year(today);
            string expectedYear = year.GetInFormat("y");

            Assert.AreEqual(expectedYear, actualYear);
        }

        [TestMethod]
        public void GetInFormat_Formatyy_Year()
        {
            DateTime today = DateTime.Now;
            string actualYear = today.ToString("yy");

            Year year = new Year(today);
            string expectedYear = year.GetInFormat("yy");

            Assert.AreEqual(expectedYear, actualYear);
        }

        [TestMethod]
        public void GetInFormat_Formatyyy_Year()
        {
            DateTime today = DateTime.Now;
            string actualYear = today.ToString("yyy");

            Year year = new Year(today);
            string expectedYear = year.GetInFormat("yyy");

            Assert.AreEqual(expectedYear, actualYear);
        }

        [TestMethod]
        public void GetInFormat_Formatyyyy_Year()
        {
            DateTime today = DateTime.Now;
            string actualYear = today.ToString("yyyy");

            Year year = new Year(today);
            string expectedYear = year.GetInFormat("yyyy");

            Assert.AreEqual(expectedYear, actualYear);
        }

        [TestMethod]
        public void GetInFormat_Formatyyyyy_Year()
        {
            DateTime today = DateTime.Now;
            string actualYear = today.ToString("yyyyy");

            Year year = new Year(today);
            string expectedYear = year.GetInFormat("yyyyy");

            Assert.AreEqual(expectedYear, actualYear);
        }
    }
}
