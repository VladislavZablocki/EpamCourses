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
            Coordinate current = new Coordinate();
            Coordinate desired = new Coordinate();
            try
            {
                current.Input();
                desired.Input();
                CheckerFigure checker = new CheckerFigure(current,desired);
                checker.InputColor();
                StepCounter stepCounter = new StepCounter(checker);
                int numberStep = stepCounter.Count();
                Console.WriteLine("Number of step : {0}",numberStep);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid coordinate or color");
            }
            catch (ImpossibilityStepException)
            {
                Console.WriteLine("You can't make a move");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
