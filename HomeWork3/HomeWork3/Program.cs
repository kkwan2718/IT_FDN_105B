using System;

namespace HomeWork3
{
    class Program
        // This program takes seconds and converts it into days, hours, minutes, and seconds
    {
        static void Main(string[] args)
        {
            // Conversion values
            int secInMin = 60; 
            int secInHour = secInMin * 60;
            int secInDay = secInHour * 24;

            Console.Write("Input a value(sec) to convert: "); // Prompts user for input
            string input = Console.ReadLine(); // Stores user input
            double sec = (double)double.Parse(input); // Converts user inputted value to a number
            Console.WriteLine("Seconds: {0}", sec);
            Console.WriteLine("Minutes: {0}", sec / secInMin);
            Console.WriteLine("Hours:   {0}", sec / secInHour);
            Console.WriteLine("Days:    {0}", sec / secInDay); 


            Console.ReadLine(); // Holds the display window open
        }
    }
}
