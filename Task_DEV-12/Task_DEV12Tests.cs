using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using task_DEV_12;

namespace task_DEV_12Tests
{
    [TestClass]
    public class Task_DEV12TEsts
    {
        [TestMethod]
        public void ValidatorIsCorrectPosition_CorrectPositionA1_True()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectPosition("a1");

            Assert.AreEqual(expected, true);
        }

        [TestMethod]
        public void ValidatorIsCorrectPosition_EmptyPosition_False()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectPosition("");

            Assert.AreEqual(expected, false);
        }

        [TestMethod]
        public void ValidatorIsCorrectPosition_MoreThanTwoSymbol_False()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectPosition("aa1");

            Assert.AreEqual(expected, false);
        }

        [TestMethod]
        public void ValidatorIsCorrectPosition_InvalidLetter_False()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectPosition("q1");

            Assert.AreEqual(expected, false);
        }

        [TestMethod]
        public void ValidatorIsCorrectPosition_InvalidNumber_False()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectPosition("a9");

            Assert.AreEqual(expected, false);
        }

        [TestMethod]
        public void ValidatorIsCorrectColor_WhiteColor_True()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectColor("white");

            Assert.AreEqual(expected, true);
        }

        [TestMethod]
        public void ValidatorIsCorrectColor_BlackColor_True()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectColor("black");

            Assert.AreEqual(expected, true);
        }

        [TestMethod]
        public void ValidatorIsCorrectColor_EmptyString_False()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectColor("");

            Assert.AreEqual(expected, false);
        }

        [TestMethod]
        public void ValidatorIsCorrectColor_AnotherColor_False()
        {
            Validator validator = new Validator();
            bool expected = validator.IsCorrectColor("blue");

            Assert.AreEqual(expected, false);
        }

        [TestMethod]
        public void ValidatorIsBlackCell_BlackCell_True()
        {
            Validator validator = new Validator();
            int[] position = new int[]{1,1}; 
            bool expected = validator.IsBlackCell(position);

            Assert.AreEqual(expected, true);
        }

        [TestMethod]
        public void ValidatorIsBlackCell_WhiteCell_False()
        {
            Validator validator = new Validator();
            int[] position = new int[] { 1, 2 };
            bool expected = validator.IsBlackCell(position);
            
            Assert.AreEqual(expected, false);
        }

        [TestMethod]
        public void ConverterToNumberCoordinate_a1_11()
        {
            Converter converter = new Converter();

            int[] expected = converter.ConvertToNumberFormat("a1");
            
            Assert.AreEqual(expected[0], 1);
        }

        [TestMethod]
        public void ConverterColor_WHITE_white()
        {
            Converter converter = new Converter();

            string expected = converter.ColorTrimAndToLower("WHITE");

            Assert.AreEqual(expected, "white");
        }

        [TestMethod]
        public void ConverterColor_whiteWithSpace_white()
        {
            Converter converter = new Converter();
            
            string expected = converter.ColorTrimAndToLower("  WHITE  ");

            Assert.AreEqual(expected, "white");
        }

        [TestMethod]
        public void StepCounter_FromA1ToB2_ImpossibilityOfStep()
        {
            int actual = 1;
            Validator validator = new Validator();
            Checker checker = new Checker();
            checker.CurrentPosition = new int[] { 1, 1 };
            checker.DesiredPosition = new int[] { 2, 2 };
            checker.Color = "white";
            StepCounter stepCounter = new StepCounter(checker,validator);

            int expected = stepCounter.CountStep();

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void StepCounter_WhiteMoveBack_ImpossibilityOfStep()
        {
            int actual = -1; 
            Validator validator = new Validator();
            Checker checker = new Checker();
            checker.CurrentPosition = new int[] { 2, 2 };
            checker.DesiredPosition = new int[] { 1, 1 };
            checker.Color = "white";
            StepCounter stepCounter = new StepCounter(checker, validator);

            int expected = stepCounter.CountStep();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StepCounter_BlackMoveForward_ImpossibilityOfStep()
        {
            int actual = -1;
            Validator validator = new Validator();
            Checker checker = new Checker();
            checker.CurrentPosition = new int[] { 1, 1 };
            checker.DesiredPosition = new int[] { 2, 2 };
            checker.Color = "black";
            StepCounter stepCounter = new StepCounter(checker, validator);

            int expected = stepCounter.CountStep();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StepCounter_WhiteCell_ImpossibilityOfStep()
        {
            int actual = -1;
            Validator validator = new Validator();
            Checker checker = new Checker();
            checker.CurrentPosition = new int[] { 1, 2 };
            checker.DesiredPosition = new int[] { 2, 1 };
            checker.Color = "white";
            StepCounter stepCounter = new StepCounter(checker, validator);

            int expected = stepCounter.CountStep();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StepCounter_FromA1ToB4_ImpossibilityOfStep()
        {
            int actual = -1;
            Validator validator = new Validator();
            Checker checker = new Checker();
            checker.CurrentPosition = new int[] { 1, 1 };
            checker.DesiredPosition = new int[] { 4, 2 };
            checker.Color = "white";
            StepCounter stepCounter = new StepCounter(checker, validator);

            int expected = stepCounter.CountStep();

            Assert.AreEqual(expected, actual);
        }
    }
}
