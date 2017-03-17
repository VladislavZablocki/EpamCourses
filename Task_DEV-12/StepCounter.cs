using System;

namespace task_DEV_12
{
    /// <summary>
    /// Count number of step 
    /// </summary>
    public class StepCounter
    {
        private Checker checker;
        private Validator validator;
        public StepCounter(Checker checker,Validator validator)
        {
            this.checker = checker;
            this.validator = validator;
        }

        /// <summary>
        /// Count number of step 
        /// </summary>
        /// <returns>number of step or -1 if it is impossibly</returns>
        public int CountStep()
        {
            int numberOfImpossibilityOfStep = -1;
            int step = Math.Abs(checker.DesiredPosition[1] - checker.CurrentPosition[1]);
            if (checker.Color == "white" && (checker.DesiredPosition[1] < checker.CurrentPosition[1]))
            {
                step = numberOfImpossibilityOfStep;
            }
            else if (checker.Color == "black" && (checker.CurrentPosition[1] < checker.DesiredPosition[1]))
            {
                step = numberOfImpossibilityOfStep;
            }
            else
            {
                if (!(validator.IsBlackCell(checker.CurrentPosition) && validator.IsBlackCell(checker.DesiredPosition)))
                {
                    step = numberOfImpossibilityOfStep;
                }
                if (Math.Abs(checker.CurrentPosition[0] - checker.DesiredPosition[0]) > step)
                {
                    step = numberOfImpossibilityOfStep;
                }
            }
            return step;
        }
    }
}
