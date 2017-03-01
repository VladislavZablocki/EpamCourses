namespace task_DEV_5
{
    interface ICriterion
    {
        /// <summary>
        /// calculate needed workers
        /// </summary>
        /// <param name="salaryOrProductivity">number of days for which we need to do a project
        /// or amount of money</param>
        /// <returns>selected team</returns>
        Team Calculate(double salaryOrProductivity);

        /// <summary>
        /// Calculate productivity of this team
        /// </summary>
        /// <param name="jCount">junior count</param>
        /// <param name="mCount">middle count</param>
        /// <param name="sCount">senior count</param>
        /// <param name="lCount">lead count</param>
        /// <returns>productivity</returns>
        double CalculateProductivity(int jCount, int mCount, int sCount, int lCount);
    }
}
