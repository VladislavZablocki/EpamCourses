using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_6;

namespace task_DEV_6Tests
{
    [TestClass]
    public class HourTests
    {
        [TestMethod]
        public void GetInFormat_Formath_Hour()
        {
            DateTime today = DateTime.Now;
            string actualHour = today.ToString("%h");

            Hour hour = new Hour(today);
            string expectedHour = hour.GetInFormat("h");

            Assert.AreEqual(expectedHour, actualHour);
        }

        [TestMethod]
        public void GetInFormat_Formathh_Hour()
        {
            DateTime today = DateTime.Now;
            string actualHour = today.ToString("hh");

            Hour hour = new Hour(today);
            string expectedHour = hour.GetInFormat("hh");

            Assert.AreEqual(expectedHour, actualHour);
        }

        [TestMethod]
        public void GetInFormat_FormatH_Hour()
        {
            DateTime today = DateTime.Now;
            string actualHour = today.ToString("%H");

            Hour hour = new Hour(today);
            string expectedHour = hour.GetInFormat("H");

            Assert.AreEqual(expectedHour, actualHour);
        }

        [TestMethod]
        public void GetInFormat_FormatHH_Hour()
        {
            DateTime today = DateTime.Now;
            string actualDay = today.ToString("HH");

            Hour hour = new Hour(today);
            string expectedDay = hour.GetInFormat("HH");

            Assert.AreEqual(expectedDay, actualDay);
        }
    }
}
