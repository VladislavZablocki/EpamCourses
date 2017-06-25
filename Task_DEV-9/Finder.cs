using System;
using System.IO;
using System.Collections.Generic;

namespace task_DEV_9
{
    /// <summary>
    /// Find elements
    /// </summary>
    class Finder
    {
        /// <summary>
        /// Find section in file,after that find values by key and add them
        /// </summary>
        /// <param name="section">string section</param>
        /// <param name="key">string key</param>
        /// <param name="path">path to the file</param>
        /// <returns>List with values</returns>
        public List<string> FindValuesInFile(string section, string key, string path)
        {
            List<string> resultValues = new List<string>();
            section = string.Concat("[", section.Trim(), "]");
            key = string.Concat(key.Trim(), '=');
            using (StreamReader streamReader = new StreamReader(path))
            {
                string line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (string.Compare(line, section) == 0)
                    {
                        List<string> valuesFromSection = FindValuesInSection(streamReader, key);
                        if (valuesFromSection != null)
                        {
                            resultValues.AddRange(valuesFromSection);
                        }
                    }
                }
            }
            return resultValues;
        }

        /// <summary>
        /// Find key in section and add values to the list
        /// </summary>
        /// <param name="streamReader">object of class StreamReader</param>
        /// <param name="key">string key</param>
        /// <returns>List of values in section</returns>
        private List<string> FindValuesInSection(StreamReader streamReader, string key)
        {
            List<string> valuesInSection = new List<string>();
            string line = string.Empty;
            while (!string.IsNullOrEmpty(line = streamReader.ReadLine()))
            {
                if (line.Contains(key) && string.Compare(line.Substring(0, key.Length), key) == 0)
                {
                    valuesInSection.Add(line.Substring(key.Length));
                }
            }
            return valuesInSection;
        }
    }
}
