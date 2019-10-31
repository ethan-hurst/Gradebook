using System;
using System.Collections.Generic;

namespace Gradebook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Ethans Grade Book");
      book.AddGrade(89.1);
      book.AddGrade(90.5);
      book.AddGrade(77.5);

      var stats = book.GetStatistics();
      Console.WriteLine($"The average grade is {stats.Average:N2}");
      Console.WriteLine($"The Highest grade is {stats.HighValue:N2}");
      Console.WriteLine($"The Lowest grade is {stats.LowValue:N2}");
    }
  }
}
