using System;
using System.Collections.Generic;

namespace task_DEV_3
{
    /// <summary>
    /// Class in which are searching the oldest person
    /// </summary>
    class OldestPerson
    {
        /// <summary>
        /// Search the oldest person and output information about him
        /// </summary>
        /// <param name="persons">List of input persons</param>
        public void SearchOldestPerson(List<Person> persons)
        {
            int max = 0;
            foreach (var item in persons)
            {
                if (max<item.GetAge())
                {
                    max = item.GetAge();
                }
            }
            Console.WriteLine("-----------------");
            Console.WriteLine("Oldest people : ");
            foreach (var item in persons)
            {
                if (item.GetAge() == max)
                {
                    item.OutputInformationAboutPerson();
                }
            }
        }
    }
}
