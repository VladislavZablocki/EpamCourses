using System;
using System.Collections.Generic;
using System.IO;

namespace task_DEV_10
{
    /// <summary>
    /// Parse file to object of class Customer
    /// </summary>
    class FromFileToObjectCustomerParser : IParsable
    {
        /// <summary>
        /// Parse file to object of class Customer
        /// </summary>
        /// <param name="path">inputpath</param>
        /// <returns>object of class Customer</returns>
        public object Parse(string path)
        {
            Customer customer = new Customer();
            string[] keyAndValue;
            try
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    string line = string.Empty;
                    while((line = streamReader.ReadLine()) != null)
                    {
                        keyAndValue = FindKeyValueInString(line);
                        if (keyAndValue.Length > 1)
                        {
                            if (keyAndValue[0].Contains("orderID"))
                            {
                                customer.OrderID = int.Parse(keyAndValue[1]);
                            }
                            if (keyAndValue[0].Contains("customerName"))
                            {
                                customer.CustomerName = keyAndValue[1];
                            }
                            if (keyAndValue[0].Contains("customerEmail"))
                            {
                                customer.CustomerEmail = keyAndValue[1];
                            }
                            if (keyAndValue[0].Contains("orderCompleted"))
                            {
                                customer.OrderCompleted = bool.Parse(keyAndValue[1]);
                            }
                            if (keyAndValue[0].Contains("purchase"))
                            {
                                List<Purchase> purchaseList = FindKeyAndValueInPurchase(streamReader);
                                customer.purchase = purchaseList;
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Please check path to the file");
            }
            return customer;
        }

        /// <summary>
        /// parse purchase to list of purchase of customer
        /// </summary>
        /// <param name="streamReader"></param>
        /// <returns> list of purchase</returns>
        private List<Purchase> FindKeyAndValueInPurchase(StreamReader streamReader)
        {
            List<Purchase> purchaseList = new List<Purchase>();
            
            string[] keyAndValue = null;
            char[] separators = {':'};
            char[] extraSymbolInStartOrEndOfPath = { '"',' ',',' };
            string line = string.Empty;
            int count = 0;
            while (!(line = streamReader.ReadLine()).Contains("]"))
            {
                Purchase purchase = new Purchase();
                while (!line.Contains("}"))
                {
                    line = streamReader.ReadLine();
                    keyAndValue = line.Split(separators, 2);
                    if (keyAndValue[0].Contains("productID"))
                    {
                        purchase.ProductID = int.Parse(keyAndValue[1].Trim(extraSymbolInStartOrEndOfPath));
                        count++;
                    }
                    else if (keyAndValue[0].Contains("productName"))
                    {
                        purchase.ProductName = keyAndValue[1].Trim(extraSymbolInStartOrEndOfPath);
                        count++;
                    }
                    else if (keyAndValue[0].Contains("quantity"))
                    {
                        purchase.Quantity = int.Parse(keyAndValue[1].Trim(extraSymbolInStartOrEndOfPath));
                        count++;
                    }
                    if(count==3)
                    {
                        purchaseList.Add(purchase);
                        count = 0;
                    }
                }
            }
            return purchaseList;
        }

        /// <summary>
        /// Find key and value in line of file
        /// </summary>
        /// <param name="line">line</param>
        /// <returns>array with key and value</returns>
        private string[] FindKeyValueInString(string line)
        {
            char[] separators = {':'};
            char[] extraSymbolInStartOrEndOfPath = { '"',' ',',' };
            string[] keyAndValue = line.Split(separators, 2);
            if (keyAndValue.Length > 1)
            {
                keyAndValue[0] = keyAndValue[0].Trim(extraSymbolInStartOrEndOfPath);
                keyAndValue[1] = keyAndValue[1].Trim(extraSymbolInStartOrEndOfPath);
            }
            return keyAndValue;
        }
    }
 
}
