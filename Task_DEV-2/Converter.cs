using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    // Class which gets string from "Checker" and convert it 
    // in postfix format
    class Converter
    {
        private string inputString;
        private string expressionOperator = "*-+/()";
        enum Operation { Default, Add,Subtract,Multiply,Divide };

        // concstructor 
        public Converter(string inputString)
        {
            this.inputString = inputString;
        }

        // splittig string to array of string
        // in this array elements is operator or numbers
        private string[] SplittingString()
        {
            string[] splittingSring = new string[GetQuantityOfOperation()];
            string cell = null; // cell contains incomplete string of numbers
            bool isOperator = false;
            int newCount = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                foreach (var oper in expressionOperator)
                {
                    if (inputString[i] == oper) // finding operator
                    {
                        isOperator = true;
                        break;
                    }
                }
                if (isOperator == false)
                {
                    cell = String.Concat(cell, inputString[i]);
                    // if we have exponentional form we add to cell next symbol + or -
                    if (inputString[i] == 'E' || inputString[i] == 'e') 
                    {
                        i++;
                        cell = String.Concat(cell, inputString[i]);
                    }
                }
                else
                {
                    if (i == 0) // if it was first operator add them to splitting String
                    {
                        splittingSring[newCount] = inputString[i].ToString();
                    }
                    else
                    {
                        if (cell == null) // we cheak it to not add null cell to splitting cell
                        {
                            splittingSring[newCount] = inputString[i].ToString();
                        }
                        else // we add cell to splitting string and add operator
                        {
                            splittingSring[newCount] = cell;
                            newCount++;
                            splittingSring[newCount] = inputString[i].ToString();
                            cell = null;
                        }
                    }
                    newCount++;
                    isOperator = false;
                }
            }
            splittingSring[newCount] = cell; // add еhe remaining cell
            return splittingSring;
        }

        // return priority of operatoin
        private Operation GetPriority(string expressionOperator)
        {
            switch (expressionOperator)
            {
                case "*":
                    return Operation.Multiply;
                case "/":
                    return Operation.Subtract;
                case "+":
                    return Operation.Add;
                case "-":
                    return Operation.Divide;
                default:
                    return Operation.Default;
            }
        }

        // calculate numbers of operation to know
        // size array of string 
        public int GetQuantityOfOperation()
        {
            int count=0;
            foreach(var item in inputString)
            {
                foreach (var oper in expressionOperator)
                {
                    if (item == oper)
                    {
                        count++;
                        break;
                    }
                }
                if (item == 'e' || item == 'E')
                {
                    count--;
                }
            }
            return 2*count+1;
        }

        // converting expression from infix to postfix form 
        // it's done to make calculations easier
        public string[] ConvertingFromInfixToPostfix()
        {
            string[] stack = new string[GetQuantityOfOperation()];
            string[] outputString = new string[GetQuantityOfOperation()];
            bool isOperator = false;
            int stackCount = 0;
            int outputCount = 0;

            foreach (var items in SplittingString())
            {
                if (items == null)
                    break;
                foreach (var oper in expressionOperator)
                {
                    if (items == oper.ToString())
                    {
                        isOperator = true;
                        break;
                    }
                }
                if (isOperator == false)
                {
                    outputString[outputCount] = items;
                    outputCount++;
                }
                else 
                {
                    if (items == ")")
                    {
                        while (stack[stackCount-1] != "(")
                        {
                            outputString[outputCount] = stack[stackCount - 1];
                            stackCount--;
                            stack[stackCount] = null;
                            outputCount++;
                        }
                        stackCount--;
                        stack[stackCount] = null;
                        
                    }
                    else
                    {
                        isOperator = false;
                        if (stackCount == 0 || items=="(")
                        {
                            stack[stackCount] = items;
                            stackCount++;
                        }
                        else
                        {
                            if (GetPriority(items) >= GetPriority(stack[stackCount - 1]))
                            {
                                stack[stackCount] = items;
                                stackCount++;
                            }
                            else
                            {
                                while (stackCount > 0)
                                {
                                    outputString[outputCount] = stack[stackCount - 1];
                                    stackCount--;
                                    stack[stackCount] = null;
                                    outputCount++;
                                }
                                stack[stackCount] = items;
                                stackCount++;
                            }
                        }
                    }
                }
            }
            while (stackCount > 0)
            {
                outputString[outputCount] = stack[stackCount - 1];
                stackCount--;
                stack[stackCount] = null;
                outputCount++;
            }
            return outputString;
        }
    }
}
