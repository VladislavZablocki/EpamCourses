using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_DEV_2
{
    // Class which gets checed string and do all operation 
    class Calculator
    {
        private string inputString;
        private string expressionOperator = "*-+/";

        // constructor 
        public Calculator(string inputString)
        {
            this.inputString = inputString;
        }

        // method which make oeration with 2 variables
        // and return result
        private double[] ResultOfOperation(double[] stack, ref bool[] isNumber,
            int stackCount, string operation)
        {
            double firstVariable = 0;
            double secondVariable = 0;
            int i = 0;
            while (i < stackCount)
            {
                i++;
                if (isNumber[stackCount - i])
                {
                    secondVariable = stack[stackCount - i];
                    isNumber[stackCount - i] = false;
                    stack[stackCount - i] = 0;
                    while (i < stackCount)
                    {
                        i++;
                        if (isNumber[stackCount - i])
                        {
                            firstVariable = stack[stackCount - i];
                            isNumber[stackCount - i] = false;
                            stack[stackCount - i] = 0;
                            break;
                        }
                    }
                    isNumber[stackCount] = true;
                    break;
                }

            }
            switch (operation)
            {
                case "*":
                    stack[stackCount] = firstVariable * secondVariable;
                    return stack;
                case "/":
                    stack[stackCount] = firstVariable / secondVariable;
                    return stack;
                case "+":
                    stack[stackCount] = firstVariable + secondVariable;
                    return stack;
                case "-":
                    stack[stackCount] = firstVariable - secondVariable;
                    return stack;
                default:
                    return stack;
            }

        }

        // method which gets string in postfix format and do all operation
        // and return result
        public double Calculate()
        {
            Converter converter = new Converter(inputString);
            bool isOperator = false;
            string[] outputString = converter.ConvertingFromInfixToPostfix();
            double[] stack = new double[converter.GetQuantityOfOperation()];
            bool[] isNumber = new bool[converter.GetQuantityOfOperation()];
            int stackCount = 0;
            string operation=null;

            foreach (var item in outputString)
            {
                if (item == null)
                {
                    break;
                }
                foreach (var oper in expressionOperator)
                {
                    if (item == oper.ToString())
                    {
                        isOperator = true;
                        operation = oper.ToString();
                        break;
                    }
                }
                if (isOperator == false && item!=null)
                {
                    isNumber[stackCount] = true;
                    stack[stackCount] = Double.Parse(item);
                }
                else
                {
                    stack = ResultOfOperation(stack,ref isNumber, stackCount, operation);
                    isOperator = false;
                }
                stackCount++;
            }
            return stack[stackCount-1];
        } 
    }
}
