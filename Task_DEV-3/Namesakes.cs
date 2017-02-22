using System;
using System.Collections.Generic;

namespace task_DEV_3
{
    /// <summary>
    /// Class in which find namesakes
    /// </summary>
    class Namesakes
    {
        /// <summary>
        /// Method in which we sort person by surname, find all namesakes and output their 
        /// </summary>
        /// <param name="persons">List of input persons</param>
        public void SearchNamesakes(List<Person> persons)
        {
            string currentSurname=null;
            int namesakesCount = 0;

            persons.Sort((a, b) => a.GetSurname().CompareTo(b.GetSurname()));
            for (int i = 0; i < persons.Count;i++ )
            {
                if ((currentSurname != persons[i].GetSurname() || i == persons.Count - 1) && namesakesCount > 1)
                {
                    namesakesCount = 0;
                    Console.WriteLine("Namesakes with surname : " + currentSurname);
                    foreach (var namesakes in persons)
                    {
                        if (namesakes.GetSurname() == currentSurname)
                        {
                            namesakes.OutputInformationAboutPerson();
                        }
                    }
                }
                else
                {
                    namesakesCount++;
                    currentSurname = persons[i].GetSurname();
                }
            }
        }
    }
}
