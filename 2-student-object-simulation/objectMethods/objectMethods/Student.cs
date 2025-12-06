using System;
using System.Collections.Generic;
using System.Text;

namespace objectMethods
{
    internal class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int year { get; set; }
        public string course { get; set; }
        public string section { get; set; }
        public int midtermGrade { get; set; }
        public int finalGrade { get; set; }

        public Student(string firstName, string lastName, int year, string course, string section, int midtermGrade, int finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public static void introduceSelf(string firstName, string lastName, int year, string course, string section)
        {
            Console.WriteLine($"Hello, my name is {firstName} {lastName}. I am a {year} year student enrolled in the {course} program, section {section}.");
        }

        public static double evaluateGrade(int midtermGrade, int finalGrade)
        {
            return (midtermGrade + finalGrade) / 2.0;
        }

    }
}
