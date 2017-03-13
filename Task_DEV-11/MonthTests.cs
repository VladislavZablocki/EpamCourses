using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_6;
using System.Globalization;
using System.Threading;

namespace task_DEV_6Tests
{
    [TestClass]
    public class MonthTests
    {
        [TestMethod]
        public void GetInFormat_FormatM_Month()
        {
            DateTime today = DateTime.Now;
            string actualMonth = today.ToString("%M");

            Month month = new Month(today);
            string expectedMonth = month.GetInFormat("M");

            Assert.AreEqual(expectedMonth, actualMonth);
        }

        [TestMethod]
        public void GetInFormat_FormatMM_Month()
        {
            DateTime today = DateTime.Now;
            string actualMonth = today.ToString("MM");

            Month month = new Month(today);
            string expectedMonth = month.GetInFormat("MM");

            Assert.AreEqual(expectedMonth, actualMonth);
        }

        [TestMethod]
        public void GetInFormat_FormatMMM_AbbreviatedMonth()
        {
            DateTime today = DateTime.Now;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string actualMonth = today.ToString("MMM");
                
            Month month = new Month(today);
            string expectedMonth = month.GetInFormat("MMM");

            Assert.AreEqual(expectedMonth, actualMonth);
        }

        [TestMethod]
        public void GetInFormat_FormatMMMM_FullMonth()
        {
            DateTime today = DateTime.Now;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string actualMonth = today.ToString("MMMM");

            Month month = new Month(today);
            string expectedMonth = month.GetInFormat("MMMM");

            Assert.AreEqual(expectedMonth, actualMonth);
        }
    }
}
