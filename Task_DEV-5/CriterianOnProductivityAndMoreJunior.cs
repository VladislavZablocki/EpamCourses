namespace task_DEV_5
{
    /// <summary>
    /// Select team by 3 criterian
    /// </summary>
    class CriterianOnProductivityAndMoreJunior : ICriterion
    {
        /// <summary>
        /// calculate needed workers
        /// </summary>
        /// <param name="Productivity">number of days for which we need to do a project</param>
        /// <returns>selected team</returns>
        public Team Calculate(double Productivity)
        {
            Team team = new Team();
            if (Productivity > Junior.PRODUCTIVITY)
            {
                team.JuniorCount = 1;
            }
            else
            {
                for (int juniorCount = 0; CalculateProductivity(juniorCount, 0, 0, 0) <= 1 / Productivity; juniorCount++)
                {
                    team.JuniorCount = juniorCount;
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
