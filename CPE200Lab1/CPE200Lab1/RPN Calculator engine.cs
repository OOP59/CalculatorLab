using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CPE200Lab1
{
        //This class inherits from CalculatorEngine
        //This class is subclass CalculatorEngine is superclass
    class RPN_Calculator_engine : CalculatorEngine
    {
        public new string Process(string str)
        {
            string result = "";
            Stack<string> myStack = new Stack<string>();
            List<string> parts = str.Split(' ').ToList<string>();
            for(int i = 0;i<=parts.Count-1;i++)
            {
                
                if (isNumber(parts[i]))
                {
                    myStack.Push(parts[i]);
                }
                
                if (isOperator(parts[i]))
                {
                    string secondOperand  = myStack.Pop();
                    string firstOperand  = myStack.Pop();
                    result = calculate(parts[i], secondOperand, firstOperand);

                    myStack.Push(result);


                }
            }           


            return result;
        }
    }
}
