using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_6;

namespace task_DEV_6Tests
{
    [TestClass]
    public class MinutesTests
    {
        [TestMethod]
        public void GetInFormat_Formatm_Minutes()
        {
            DateTime today = DateTime.Now;
            string actualMinutes = today.ToString("%m");

            Minutes minutes = new Minutes(today);
            string expectedMinutes = minutes.GetInFormat("m");

            Assert.AreEqual(expectedMinutes, actualMinutes);
        }

        [TestMethod]
        public void GetInFormat_Formatmm_Minutes()
        {
            DateTime today = DateTime.Now;
            string actualMinutes = today.ToString("mm");

            Minutes minutes = new Minutes(today);
            string expectedMinutes = minutes.GetInFormat("mm");

            Assert.AreEqual(expectedMinutes, actualMinutes);
        }
    }
}
