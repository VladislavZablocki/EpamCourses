namespace task_DEV_5
{
    class CriterionOnSalary : ICriterion
    {
        /// <summary>
        /// Calculate needed worker 
        /// </summary>
        /// <param name="salary">salary of team</param>
        /// <returns>team</returns>
        public Team Calculate(double salary)
        {
            Team team = new Team();

            for (int leadCount = 0; leadCount * Lead.SALARY <= salary; leadCount++)
            {
                for (int seniorCount = 0; seniorCount * Senior.SALARY <= salary - leadCount * Lead.SALARY;
                    seniorCount++)
                {
                    for (int middleCount = 0; middleCount * Middle.SALARY <=
                        salary - leadCount * Lead.SALARY - seniorCount * Senior.SALARY;
                        middleCount ++)
                    {
                        for (int juniorCount = 0; juniorCount * Junior.SALARY <=
                            salary - leadCount * Lead.SALARY - seniorCount * Senior.SALARY - middleCount * Middle.SALARY;
                            juniorCount++)
                        {
                            if (team.Productivity < CalculateProductivity(juniorCount, middleCount, seniorCount, leadCount))
                            {
                                team.JuniorCount = juniorCount;
                                team.LeadCount = leadCount;
                                team.MiddleCount = middleCount;
                                team.SeniorCount = seniorCount;
                                team.Productivity = CalculateProductivity(juniorCount, middleCount, seniorCount, leadCount);
                            }
                        }
                    }
                }
            }
            return team;
        }
        
       public double CalculateProductivity(int jCount, int mCount, int sCount, int lCount)
        {
            return (double)jCount / Junior.PRODUCTIVITY + (double)mCount / Middle.PRODUCTIVITY +
                (double)sCount / Senior.PRODUCTIVITY + (double)lCount / Lead.PRODUCTIVITY;
        }
    }
}
