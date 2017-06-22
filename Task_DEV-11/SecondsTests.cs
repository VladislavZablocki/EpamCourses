using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_6;

namespace task_DEV_6Tests
{
    [TestClass]
    public class SecondsTests
    {
        [TestMethod]
        public void GetInFormat_Formats_Seconds()
        {
            DateTime today = DateTime.Now;
            string actualSeconds = today.ToString("%s");

            Seconds seconds = new Seconds(today);            
            string expectedSeconds = seconds.GetInFormat("s");

            Assert.AreEqual(expectedSeconds, actualSeconds);
        }

        [TestMethod]
        public void GetInFormat_Formatss_Seconds()
        {
            DateTime today = DateTime.Now;
            string actualSeconds = today.ToString("ss");

            Seconds seconds = new Seconds(today);
            string expectedSeconds = seconds.GetInFormat("ss");

            Assert.AreEqual(expectedSeconds, actualSeconds);
        }
    }
}
