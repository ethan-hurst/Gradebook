using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Ethans Grade Book");

            var done = false;
            while (!done)
            {
                Console.WriteLine("Please Enter a Grade\n\nPress 'q' to exit.");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    done = true;
                    continue;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("**");
                }
            }

            var stats = book.GetStatistics();
            Console.WriteLine($"The average grade is {stats.Average:N2}");
            Console.WriteLine($"The Highest grade is {stats.HighValue:N2}");
            Console.WriteLine($"The Lowest grade is {stats.LowValue:N2}");
            Console.WriteLine($"The letter grade is {stats.letter}");
        }
    }
}
