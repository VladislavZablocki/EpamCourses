using System;
namespace task_DEV_3
{
    /// <summary>
    /// Inputing information about person
    /// </summary>
    class Inputer
    {
        /// <summary>
        /// Method in which we input information about person
        /// </summary>
        /// <returns>object of class Person whith correct inputing properties </returns>
        public Person InputDataOfPerson()
        {
            Person person = new Person();
            Checker checker = new Checker();
            string name;
            string surname;
            int age=0;
            string sex;
            bool isCorrect = false;

            while (!isCorrect)
            {
                name = InputName();
                if (checker.CheckName(name))
                {
                    person.SetName(name);
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Check name!");
                }
            }
            isCorrect = false;

            while (!isCorrect)
            {
                surname = InputSurame();
                if (checker.CheckSurname(surname))
                {
                    person.SetSurname(surname);
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Check surname!");
                }
            }
            isCorrect = false;

            while (!isCorrect)
            {
                if (Int32.TryParse(InputAge(), out age) && checker.CheckAge(age))
                {
                    person.SetAge(age);
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Check age!");
                }
            }
            isCorrect = false;

            while (!isCorrect)
            {
                sex = InputSex();
                if (checker.CheckSex(sex))
                {
                    person.SetSex(sex);
                    isCorrect = true;
                }
                else
                {
                    Console.WriteLine("Check sex!");
                }
            }
            return person;
        }

        private string InputName()
        {
            Console.WriteLine("\nName : ");
            return Console.ReadLine();
        }

        private string InputSurame()
        {
            Console.WriteLine("Surname : ");
            return Console.ReadLine();
        }

        private string InputAge()
        {
            Console.WriteLine("Age : ");
            return Console.ReadLine();
        }

        private string InputSex()
        {
            Console.WriteLine("Sex (man or women) : ");
            return Console.ReadLine();
        }
    }
}
