using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Operation
    {
        public static int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public static int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        public static int Division(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }
    }
}
