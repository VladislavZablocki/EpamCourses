using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_6;

namespace task_DEV_6Tests
{
    [TestClass]
    public class DateAndTimeUserFormatsConverterTests
    {
        [TestMethod]
        public void Converter_EmptyString_Empty()
        {
            string actualString = string.Empty;
            
            DateAndTimeUserFormatsConverter DateAndTimeConverter = new DateAndTimeUserFormatsConverter();
            string expectedString = DateAndTimeConverter.Convert(string.Empty);

            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        public void Converter_HHmmss_NowTime()
        {
            DateTime now = DateTime.Now;
            string actualTime = now.ToString("HH:mm:ss");

            DateAndTimeUserFormatsConverter DateAndTimeConverter = new DateAndTimeUserFormatsConverter();
            string expectedTime = DateAndTimeConverter.Convert("HH:mm:ss");

            Assert.AreEqual(expectedTime, actualTime);
        }

        [TestMethod]
        public void Converter_ddMMyyyy_NowDate()
        {
            DateTime now = DateTime.Now;
            string actualDate = now.ToString("dd/MM/yyyy");

            DateAndTimeUserFormatsConverter DateAndTimeConverter = new DateAndTimeUserFormatsConverter();
            string expectedDate = DateAndTimeConverter.Convert("dd/MM/yyyy");

            Assert.AreEqual(expectedDate, actualDate);
        }
    }
}
