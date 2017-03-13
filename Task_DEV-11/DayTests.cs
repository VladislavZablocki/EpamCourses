using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_6;
using System.Globalization;
using System.Threading;

namespace task_DEV_6Tests
{
    [TestClass]
    public class DayTests
    {
        [TestMethod]
        public void GetInFormat_Formatd_Day()
        {
            DateTime today = DateTime.Now;
            string actualDay = today.ToString("%d");

            Day day = new Day(today);
            string expectedDay = day.GetInFormat("d");

            Assert.AreEqual(expectedDay, actualDay);
        }

        [TestMethod]
        public void GetInFormat_Formatdd_Day()
        {
            DateTime today = DateTime.Now;
            string actualDay = today.ToString("dd");

            Day day = new Day(today);
            string expectedDay = day.GetInFormat("dd");

            Assert.AreEqual(expectedDay, actualDay);
        }

        [TestMethod]
        public void GetInFormat_Formatddd_AbbreviatedDayOfWeek()
        {
            DateTime today = DateTime.Now;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string actualDayOfWeek = today.ToString("ddd");

            Day day = new Day(today);
            string expectedDayOfWeek = day.GetInFormat("ddd");

            Assert.AreEqual(expectedDayOfWeek, actualDayOfWeek);
        }

        [TestMethod]
        public void GetInFormat_Formatdddd_FullDayOfWeek()
        {
            DateTime today = DateTime.Now;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            string actualDayOfWeek = today.ToString("dddd");

            Day day = new Day(today);
            string expectedDayOfWeek = day.GetInFormat("dddd");

            Assert.AreEqual(expectedDayOfWeek,actualDayOfWeek);
        }
    }
}
