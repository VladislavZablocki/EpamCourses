namespace task_DEV_5
{
    /// <summary>
    /// Class in which we choose criterion for selection team
    /// </summary>
    class TeamSelection
    {
        private ICriterion criterian;
        public TeamSelection(ICriterion criterian)
        {
            this.criterian = criterian;
        }
        /// <summary>
        /// calculate team
        /// </summary>
        /// <param name="data">criterian</param>
        /// <returns>team</returns>
        public Team SelectTeam(int data)
        {
            Team team = new Team();
            team = criterian.Calculate(data);
            return team;
        }
    }
}
