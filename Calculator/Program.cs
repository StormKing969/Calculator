using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            int total = 0;

            while (!quit)
            {
                int num1 = UserInput.UserNum();
                string operation_type = UserInput.UserOperation();
                int num2 = UserInput.UserNum();

                Checked(operation_type, num1, num2, total);


                Console.WriteLine("Do you wish to quit?");
                string decision =  Console.ReadLine();
                if (decision == "yes")
                {
                    quit = true;
                }
                
            }
        }

        static void Checked(string operation_type, int num1, int num2, int total)
        {
            if (operation_type == "+") 
            {
                total += Operation.Addition(num1, num2);
            }
            else if (operation_type == "-")
            {
                total += Operation.Subtraction(num1, num2);
            }
            else if (operation_type == "*")
            {
                total += Operation.Multiplication(num1, num2);
            }
            else if (operation_type == "/")
            {
                total += Operation.Division(num1, num2);
            }

            Console.WriteLine("Output is " + total);
        }
    }
}
