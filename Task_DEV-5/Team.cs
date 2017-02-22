namespace task_DEV_5
{
    /// <summary>
    /// class which consists all workers
    /// </summary>
    class Team
    {
        public double Productivity { get; set; }
        public int JuniorCount { get; set; }
        public int MiddleCount { get; set; }
        public int SeniorCount { get; set; }
        public int LeadCount { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return string.Concat("Junior ",JuniorCount," ; Middle ",MiddleCount,
                " ; Senior ",SeniorCount," ; Lead ",LeadCount);
        }
      
    }
}
