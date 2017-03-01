using System;
using System.Collections.Generic;

namespace task_DEV_5
{
    class Program
    {
        /// <summary>
        /// Entry point of programm. We choose criterion of selection team and
        /// input salary or the number of days for which we need to do a project
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Inputer inputer = new Inputer();
            TeamSelection teamSelection = new TeamSelection(new CriterionOnSalary()); ;
            int[] data = new int[2];
            data = inputer.InputData();
            if (data[0] == 2)
            {
                teamSelection = new TeamSelection(new CriterionOnProductivity());
            }
            if (data[0] == 3)
            {
                teamSelection = new TeamSelection(new CriterianOnProductivityAndMoreJunior());
            }
            Console.WriteLine(teamSelection.SelectTeam(data[1]));
            Console.ReadLine();
        }
    }
}
