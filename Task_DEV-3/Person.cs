using System;
namespace task_DEV_3
{
    /// <summary>
    /// Class which include person properties 
    /// </summary>
    class Person
    {
        private string name;
        private string surname;
        private int age;
        private string sex;
        
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public string GetSurname()
        {
            return surname;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetSex(string sex)
        {
            this.sex = sex;
        }
        public string GetSex()
        {
            return sex;
        }

        /// <summary>
        /// Method output information about person
        /// </summary>
        public void OutputInformationAboutPerson()
        {   
            Console.WriteLine("Name     "+name);
            Console.WriteLine("Surname  "+surname);
            Console.WriteLine("Age      "+age);
            Console.WriteLine("Sex      "+sex);
            Console.WriteLine("-----------------");
        }
    }
}
