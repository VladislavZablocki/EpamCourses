using System;
using System.Collections.Generic;

namespace task_DEV_3
{
    /// <summary>
    /// Method in which we search the most popular woman name
    /// </summary>
    class PopularWomanName
    {
        /// <summary>
        /// Method in which we sort person by name search the most popular woman name and output it
        /// </summary>
        /// <param name="person">List of input persons</param>
        public void SearchPopularWomanName(List<Person> person)
        {
            int currentPopularCount = 0;
            int maxPopularCount = 0;
            string popularName = null;
            string currentName = null;
            person.Sort((a, b) => a.GetName().CompareTo(b.GetName()));
            foreach (var item in person)
            {
                if (item.GetSex() == "women")
                {
                    if (currentName != item.GetName())
                    {
                        currentName = item.GetName();
                        currentPopularCount++;
                        if (currentPopularCount > maxPopularCount)
                        {
                            maxPopularCount = currentPopularCount;
                            popularName = currentName;
                        }
                    }
                    else
                    {
                        currentPopularCount++;
                    }
                }
            }
            if (currentPopularCount > maxPopularCount)
            {
                maxPopularCount = currentPopularCount;
                popularName = currentName;
            }
            if (maxPopularCount == 0)
            {
                Console.WriteLine("No women");
            }
            else
            {
                Console.WriteLine("Most popular woman name is : " + popularName + 
                    ", it meets " + maxPopularCount + " times");
            }
        }
    }
}
