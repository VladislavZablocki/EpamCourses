using System;
using System.Collections.Generic;

namespace task_DEV_3
{
    /// <summary>
    /// Class in which we calculate average age of all persons
    /// </summary>
    class AverageAge
    {
        /// <summary>
        /// Method in which we calculate average age of person and output this number
        /// </summary>
        /// <param name="persons">List of input persons</param>
        public void CalculateAverageAge(List<Person> persons)
        {
            float sum = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                sum += persons[i].GetAge();
            }
            Console.WriteLine("\n-----------------");
            Console.WriteLine("Average age : "+sum/persons.Count);
        }
    }
}
