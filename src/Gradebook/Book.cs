
using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.Name = name;
        }
        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0)
            {
                grades.Add(grade);
            }
            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}!");
            }
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.HighValue = double.MinValue;
            result.LowValue = double.MaxValue;

            for (var index = 0; index < grades.Count; index += 1)
            {
                result.HighValue = Math.Max(grades[index], result.HighValue);
                result.LowValue = Math.Min(grades[index], result.LowValue);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;
            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.letter = 'B';
                    break;
                case var d when d >= 70.0:
                    result.letter = 'C';
                    break;
                case var d when d >= 60.0:
                    result.letter = 'D';
                    break;
                default:
                    result.letter = 'F';
                    break;
            }
            return result;
        }
        private List<double> grades;
        public string Name;
    }
}
