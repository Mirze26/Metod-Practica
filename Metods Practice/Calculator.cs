using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods_Practice
{
    internal class Calculator
    {
        public double Calculation (int num1,int num2, string operation)
        {
            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1+num2;
                    return result;
                    break;
                case "-":
                    result = num1- num2;
                    return result;
                    break;
                    case "*":
                    result = num1* num2;
                    return result;
                    break;
                    case "/":
                    result = num1/ num2;
                    return result;
                    break;
                    default:
                    Console.WriteLine("Please add correct operation");
                    return result;
            }

            



        }








    }
}
