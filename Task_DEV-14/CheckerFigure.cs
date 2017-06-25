using System;

namespace task_DEV_12
{
    /// <summary>
    /// Class with information about checker.
    /// </summary>
    public class CheckerFigure
    {
        private Coordinate current;
        private Coordinate desired;
        public string Color { get; set; }

        public CheckerFigure(Coordinate current,Coordinate desired)
        {
            this.current = current;
            this.desired = desired;
        }

        public Coordinate GetCurrent()
        {
            return current;
        }

        public Coordinate GetDesired()
        {
            return desired;
        }

        public void InputColor()
        {
            Console.WriteLine("Input color of figure : ");
            Color = Console.ReadLine().ToLower().Trim();
            ValidateColor();
        }


        public void ValidateColor()
        {
            if (!(string.Equals(Color, "white") || string.Equals(Color, "black")))
            {
                throw new FormatException();
            }
        }
    }
}
