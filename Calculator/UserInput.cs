using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class UserInput
    {
        public static string UserOperation()
        {
            Console.Write("What type of operation: ");
            string operation_type = Console.ReadLine();

            return operation_type;
        }

        public static int UserNum()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            return num;
        }
    }
}
