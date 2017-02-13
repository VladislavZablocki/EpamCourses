using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    // Class in which we check the correctness of input srting
    class Checker
    {
        private string expressionOperator = "*-+/";

        // method check input string for correctness 
        public bool CheakInputString(ref string inputString)
        {
            bool error = false;
            inputString = EditingString(inputString);

            if (CheckRecordNumbersInExponentForm(inputString))
            {
                error = true;
                Console.WriteLine("Check exponention form of numbers!");
            }
            if (error == false)
            {
                if (BracketsCount(inputString) > 0)
                {
                    error = true;
                    Console.WriteLine("You have more closed brackets!");
                }
                if (BracketsCount(inputString) < 0)
                {
                    error = true;
                    Console.WriteLine("You have more open brackets!");
                }
            }
            if (error == false)
            {
                if (CheckNeighboringOperator(inputString))
                {
                    error = true;
                    Console.WriteLine("You have 2 or more neighboring operators!");
                }
            }
            if (error)
            {
                Console.WriteLine("Error! Check your input data!");
                Console.ReadKey();
                return false;
            }
            else
            {
                return true;
            }
        }

        // Method which check the neighboring operators
        // for example 6+-7 is incorrect
        private bool CheckNeighboringOperator(string inputString)
        {
            for(int i=0;i<inputString.Length;i++)
            {
                foreach (var firstOper in expressionOperator)
                {
                    if (inputString[i] == firstOper)
                    {
                        foreach (var secondOper in expressionOperator)
                        {
                            if (i + 1 < inputString.Length)
                            {
                                if (inputString[i + 1] == secondOper)
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            return false;
        }

        // Method which return input string without space ' ', dot '.' and return 
        // negative numbers in this form : "(0-number)"
        private string EditingString(string inputString)
        {
            inputString = inputString.Replace(" ", "");
            inputString = inputString.Replace('.', ',');
            string outputString = inputString;
            for (int i = 0; i < inputString.Length; i++)
            {
                if(inputString[i]=='-'&&inputString[i-1]=='(')
                {
                    outputString = inputString.Insert(i, "0");
                }
            }
            return outputString; 
        }

        // method which check open and closed brackets
        // if difference!=0 we get error message 
        private int BracketsCount(string inputString)
        {
            int difference = 0;
            int openBracketsCount = 0;
            int closeBracketsCount = 0;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    openBracketsCount++;
                }
                if (inputString[i] == ')')
                {
                    closeBracketsCount++;
                }
            }
            difference = closeBracketsCount - openBracketsCount;
            return difference;
        }
        
        // method which checkcorrectness of record numbers in exponention form
        private bool CheckRecordNumbersInExponentForm(string inputString)
        {
            for (int i = 0; i < inputString.Length; i++)
            {
                if ((inputString[i] == 'e' || inputString[i] == 'E') &&
                    (inputString[i + 1] != '+' && inputString[i + 1] != '-'))
                {
                    return true;
                }
                if (i + 2 < inputString.Length)
                {
                    if ((inputString[i] == 'e' || inputString[i] == 'E') &&
                        (inputString[i + 2] < 48 || inputString[i + 2] > 57))
                    {
                        return true;
                    }
                }
                if (inputString[i]=='e')
                {
                    if(i==0)
                    {
                        return true;
                    }
                    else 
                    {
                        if (inputString[i - 1] < 48 || inputString[i - 1] > 57)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
