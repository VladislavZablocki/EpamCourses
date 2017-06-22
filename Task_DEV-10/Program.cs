using System;
using System.Collections.Generic;

namespace task_DEV_10
{
    class Program
    {
        /// <summary>
        /// Entry point of program. Get input and outpur path from config.json
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string configPath = @"E:\c#\task_DEV-10\task_DEV-10\config.json";
            ConfigReader configReader = new ConfigReader(configPath);
            IParsable parser = new FromFileToObjectCustomerParser();
            IWritable writer = new WriteObjectCustomerToFile();
            string inputPath = configReader.GetInputPath();
            string outputPath = configReader.GetOutputPath();
            Customer customer =(Customer)parser.Parse(inputPath);
            writer.Write(customer, outputPath);
        }
    }
}
