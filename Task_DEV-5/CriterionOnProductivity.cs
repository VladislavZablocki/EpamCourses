using System;

namespace task_DEV_5
{
    class CriterionOnProductivity : ICriterion
    {
        /// <summary>
        /// calculate needed workers
        /// </summary>
        /// <param name="Productivity">number of days for which we need to do a project</param>
        /// <returns>selected team</returns>
        public Team Calculate(double Productivity)
        {
            Team team = new Team();
            team.Salary=0;
            for (int leadCount = 0; CalculateProductivity(0, 0, 0, leadCount) <= 1 / Productivity; leadCount++)
            {
                for (int seniorCount = 0; CalculateProductivity(0, 0, seniorCount, leadCount) <= 1 / Productivity; seniorCount++)
                {
                    for (int middleCount = 0; CalculateProductivity(0, middleCount, seniorCount, leadCount) <= 1 / Productivity; middleCount++)
                    {
                        for (int juniorCount = 0; CalculateProductivity(juniorCount, middleCount, seniorCount, leadCount) <= 1 / Productivity; juniorCount++)
                        {
                            team.JuniorCount = juniorCount;
                            team.LeadCount = leadCount;
                            team.MiddleCount = middleCount;
                            team.SeniorCount = seniorCount;
                            team.Salary = CalculateSalary(juniorCount, middleCount, seniorCount, leadCount);
                        }
                    }
                }
            }
            return team;
        }

        /// <summary>
        /// calculate salary of team
        /// </summary>
        /// <param name="jCount">junior count</param>
        /// <param name="mCount">middle count</param>
        /// <param name="sCount">senior count</param>
        /// <param name="lCount">lead count</param>
        /// <returns>salary of this team</returns>
        private int CalculateSalary(int jCount, int mCount, int sCount, int lCount)
        {
            return jCount * Junior.SALARY + mCount * Middle.SALARY + sCount * Senior.SALARY + lCount * Lead.SALARY;
        }

       public double CalculateProductivity(int jCount, int mCount, int sCount, int lCount)
        {
            return (double)jCount / Junior.PRODUCTIVITY + (double)mCount / Middle.PRODUCTIVITY +
                (double)sCount / Senior.PRODUCTIVITY + (double)lCount / Lead.PRODUCTIVITY;
        }
    }
}
