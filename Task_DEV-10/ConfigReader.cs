using System;
using System.IO;

namespace task_DEV_10
{
    /// <summary>
    /// Read json file and return input\output path
    /// </summary>
    class ConfigReader
    {
        private string configPath;

        public ConfigReader(string configPath)
        {
            this.configPath = configPath;
        }
        
        /// <summary>
        /// Find input path in config.json
        /// </summary>
        /// <returns>input path</returns>
        public string GetInputPath()
        {
            string inputPath = string.Empty;
            try
            {
                using(StreamReader streamReader = new StreamReader(configPath))
                {
                    string line = string.Empty;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        inputPath = FindValueInLineByKey(line,"input");
                        if (inputPath != string.Empty)
                        {
                            break;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Please check path to the config");
            }
            return inputPath;
        }

        /// <summary>
        /// Find output path in config.json
        /// </summary>
        /// <returns>output path</returns>
        public string GetOutputPath()
        {
            string outputPath = string.Empty;
            try
            {
                using (StreamReader streamReader = new StreamReader(configPath))
                {
                    string line = string.Empty;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        outputPath = FindValueInLineByKey(line, "output");
                        if (outputPath != string.Empty)
                        {
                            break;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Please check path to the config");
            }
            return outputPath;
        }

        /// <summary>
        /// Find value in line of file
        /// </summary>
        /// <param name="line">line</param>
        /// <param name="key">key</param>
        /// <returns>path</returns>
        private string FindValueInLineByKey(string line,string key)
        {
            string value = string.Empty;
            char[] separators = {':'};
            char[] extraSymbolInStartOrEndOfPath = {'"'};
            string[] splittingLine = line.Split(separators,2);
            if (splittingLine[0].Contains(key))
            {
                value = splittingLine[1].Substring(splittingLine[1].IndexOf('"'));
                value = value.Trim(extraSymbolInStartOrEndOfPath);
            }
            return value;
        }
    }
}
