using System;

namespace task_DEV_12
{
    class Program
    {
        /// <summary>
        /// Entry point of programm. Input start and desired position and color of checker.
        /// Calculate number of step.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Inputer inputer = new Inputer();
            Checker checker = new Checker();
            Converter converter = new Converter();
            Validator validator = new Validator();
            int step = 0;
            checker.Color = converter.ColorTrimAndToLower(inputer.InputColor());
            string currentPosition = inputer.InputCurrentPosition();
            string desiredPosition = inputer.InputDesiredPosition();
            if (validator.IsCorrectPosition(currentPosition)
                && validator.IsCorrectPosition(desiredPosition)
                && validator.IsCorrectColor(checker.Color))
            {
                checker.CurrentPosition = converter.ConvertToNumberFormat(currentPosition);
                checker.DesiredPosition = converter.ConvertToNumberFormat(desiredPosition);
                StepCounter stepCounter = new StepCounter(checker, validator);
                step = stepCounter.CountStep();
                if (step < 0)
                {
                    Console.WriteLine("It's imposiable to move");
                }
                else
                {
                    Console.WriteLine("Step count : {0}", step);
                }
            }
            else
            {
                Console.WriteLine("You input incorrect date.");
            }
            Console.ReadLine();
        }
    }
}
