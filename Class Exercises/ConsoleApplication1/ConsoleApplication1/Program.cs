using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        { // 5x^2 + 6

            Console.Write("Input a value for x: ");
            string n = Console.ReadLine();
            int num = int.Parse(n);
            Console.WriteLine("it is: {0}", 5 * num * num + 6);

            Console.ReadLine(); // holds the display open
        }
    }
}
