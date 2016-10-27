using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_Factorial
{
    class Program
        // This program calculates the factorial of an inputted value.
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value to calculate its factorial: ");
            double n = (double)double.Parse(Console.ReadLine()); // Reads user input and converts to integer
            double sol = 1;

            while (n != 0)
            {
                sol = sol * n;
                n--;
            }

            Console.WriteLine(sol); // Writes solution onto display
            Console.ReadLine(); // Keeps the display open for viewing
        }
    }
}
