using System;
using System.Collections.Generic;

namespace task_DEV_3
{
    class Program
    {
        /// <summary>
        /// Method in which we check is need to add person 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool isNeedToAddPerson=true;
            List<Person> persons = new List<Person>();
            Inputer inputer = new Inputer();
            AverageAge averageAge = new AverageAge();
            OldestPerson oldestPerson = new OldestPerson();
            PopularWomanName popularWomanName = new PopularWomanName();
            Namesakes namesakes = new Namesakes();

            while (isNeedToAddPerson)
            {
                persons.Add(inputer.InputDataOfPerson());
                Console.WriteLine("Do you want to add person? (y or n)");
                if (Console.ReadKey().KeyChar == 'n')
                {
                    isNeedToAddPerson = false;
                }
            }
            averageAge.CalculateAverageAge(persons);
            oldestPerson.SearchOldestPerson(persons);
            popularWomanName.SearchPopularWomanName(persons);
            namesakes.SearchNamesakes(persons);
            Console.ReadKey();
        }
    }
}
