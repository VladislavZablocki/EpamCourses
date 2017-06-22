using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace task_DEV_10
{
    /// <summary>
    /// Write data of object of class Customer to file
    /// </summary>
    class WriteObjectCustomerToFile : IWritable
    {
        /// <summary>
        /// Write data of object of class Customer to file
        /// </summary>
        /// <param name="objectOfClass">object of class</param>
        /// <param name="pathToFile">output path</param>
        public void Write(object objectOfClass, string pathToFile)
        {
            Customer customer = (Customer)objectOfClass;
            Type type = typeof(Customer);
            PropertyInfo[] propertyInfo = type.GetProperties();
            List<object> valueList = new List<object> { customer.OrderID, customer.CustomerName, customer.CustomerEmail, customer.OrderCompleted };
            try
            {
                using(StreamWriter streamWriter = new StreamWriter(pathToFile))
                {
                    streamWriter.WriteLine("{");
                    for (int i = 0; i < valueList.Count; i++)
                    {
                        streamWriter.WriteLine(MakeStringJsonFile(propertyInfo[i], valueList[i]));
                    }
                    WritePurchase(streamWriter,customer.purchase);
                    streamWriter.WriteLine("}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Please check path to the file");
            }
        }

        /// <summary>
        /// write data about purchase of customer
        /// </summary>
        /// <param name="streamWriter"></param>
        /// <param name="purchase">list of purchase</param>
        private void WritePurchase(StreamWriter streamWriter,List<Purchase> purchase)
        {
            Type type = typeof(Purchase);
            streamWriter.WriteLine("\t\"purchase\": [");
            foreach (var item in purchase)
            {
                List<object> valueList = new List<object> { item.ProductID, item.ProductName, item.Quantity };
                PropertyInfo[] propertyInfo = type.GetProperties();
                streamWriter.WriteLine("\t\t{");
                for (int i = 0; i < valueList.Count; i++)
                {
                    streamWriter.WriteLine("\t\t"+MakeStringJsonFile(propertyInfo[i], valueList[i]));
                }
                streamWriter.WriteLine("\t\t},");
            }
            streamWriter.WriteLine("\t]");
        }

        /// <summary>
        /// Make string with key-value 
        /// </summary>
        /// <param name="propertyInfo">information about propeerty</param>
        /// <param name="value">value of this property</param>
        /// <returns></returns>
        private string MakeStringJsonFile(PropertyInfo propertyInfo,object value)
        {
            if (value is string)
            {
                value = string.Concat("\"", value, "\": ");
            }
            return string.Concat("\t","\"", propertyInfo.Name, "\": ", value);
        }
    }
}

