
using System;
using System.Collections.Generic;

namespace Gradebook
{
  public class Book
  {
    public Book(string name)
    {
      grades = new List<double>();
      this.name = name;
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }
    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.Average = 0.0;
      result.HighValue = double.MinValue;
      result.LowValue = double.MaxValue;

      foreach (double grade in grades)
      {
        result.HighValue = Math.Max(grade, result.HighValue.);
        result.LowValue = Math.Min(grade, result.LowValue);
        result.Average += grade;

        result.Average /= grades.Count;
      }
    }
    private List<double> grades;
    private string name;
  }
}
