using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Assignments_on_Class_Objects
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }

        private List<double> grades;
        public Student(string name, string id)
        {
            Name = name;
            ID = id;
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                Console.WriteLine($"Grade {grade} added for {Name}");
            }
            else
            {
                Console.WriteLine("Invalid grade");
            }
        }
        public double CalculateAverageGrade()
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("No grades to calculate average");
                return 0;
            }

            double total = 0;

            foreach (double grade in grades)
            {
                total += grade;
            }

            return total / grades.Count;
        }
    }
}
