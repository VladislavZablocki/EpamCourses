using System;

namespace task_DEV_12
{
    /// <summary>
    /// Count number of step 
    /// </summary>
    public class StepCounter
    {
        public enum ColorOfField { white, black };
        private CheckerFigure checker;
        public StepCounter(CheckerFigure checker)
        {
            this.checker = checker;
        }

         //<summary>
         //Count number of step 
         //</summary>
         //<returns>number of step or -1 if it is impossibly</returns>
        public int Count()
        {
            int numberStep = Math.Abs(checker.GetDesired().Position[1] - checker.GetCurrent().Position[1]);
            //if white figure want to go down
            if (checker.Color == "white" && (checker.GetDesired().Position[1] < checker.GetCurrent().Position[1]))
            {
                throw new ImpossibilityStepException();
            }
                 //if black figure want to go up
            else if (checker.Color == "black" && (checker.GetCurrent().Position[1] < checker.GetDesired().Position[1]))
            {
                throw new ImpossibilityStepException();
            }
            else
            {
                //if figure stay on white cell
                if ((checker.GetCurrent().GetPositionColor() == Coordinate.ColorOfField.white)
                    || checker.GetDesired().GetPositionColor() == Coordinate.ColorOfField.white)
                {
                    throw new ImpossibilityStepException();
                }
                if (Math.Abs(checker.GetCurrent().Position[0] - checker.GetDesired().Position[0]) > numberStep)
                {
                    throw new ImpossibilityStepException();
                }
            }
            return numberStep;
        }
    }
}
