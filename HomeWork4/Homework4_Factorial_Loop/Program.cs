using System;


namespace Homework4_Factorial_Loop
{
    class Program
        // This program allows the user to enter the number of factorials to display.
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: "); // Asks the user to input a value
            int input = int.Parse(Console.ReadLine()); // Reads user input and converts to integer

            for (int i = 1; i <= input; i++)
            {
                double fac = 1;
                int n = i;

                // Solves for factorial of each value
                while (n != 0)
                {
                    fac = fac * n;
                    n--;
                }
                	
                Console.WriteLine("{0}!      =       {1}", i, fac); // Displays each factorial value
            }

            Console.ReadLine(); // Holds the display window open.
        }
    }
}
