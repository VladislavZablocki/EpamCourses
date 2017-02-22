using System;

namespace task_DEV_5
{
    /// <summary>
    /// Input criterion of selection and the number of days for which we need to do a project
    /// or amount of money
    /// </summary>
    class Inputer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns> array data; first element - criterion;second - number of day
        /// or amount of money</returns>
        public int[] InputData()
        {
            int[] data = new int[2];
            bool isError = true;
            while (isError)
            {
                Console.WriteLine("Input number of criterion:");
                if (int.TryParse(Console.ReadLine(), out data[0]) && data[0]>0 && data[0]<4)
                {
                    isError = false;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            data[1] = InputSalaryOrProductivity(data[0]);
            return data;
        }

        /// <summary>
        /// input needed information for searching team
        /// </summary>
        /// <param name="criterion">criterion of selection team</param>
        /// <returns>second element of array data</returns>
        private int InputSalaryOrProductivity(int criterion)
        {
            int salaryOrProductivity = 0;
            if (criterion == 1)
            {
                Console.WriteLine("Input amount of money :");
                salaryOrProductivity = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Input the number of days for which we need to do a project :");
                salaryOrProductivity = int.Parse(Console.ReadLine());
            }
            return salaryOrProductivity;
        }
    }
}
