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
            string yearLevel = year == 1 ? "1st" : year == 2 ? "2nd" : year == 3 ? "3rd" : $"{year}th";
            Console.WriteLine($"Hello, my name is {firstName} {lastName}. I am a {yearLevel} year student enrolled in the {course} program, section {section}.");
        }

        public static void evaluateGrade(int midtermGrade, int finalGrade)
        {
            double grade = (midtermGrade + finalGrade) / 2.0;

            if (grade >= 98)
                Console.WriteLine($"{grade}: With Highest Honor");
            else if (grade >= 95)
                Console.WriteLine($"{grade}: With High Honor");
            else if (grade >= 90)
                Console.WriteLine($"{grade}: With Honor");
            else if (grade >= 75)
                Console.WriteLine($"{grade}: Passed");
            else if (grade < 0 && grade > 100)
                Console.WriteLine($"{grade}: Invalid Grade");
            else
                Console.WriteLine($"{grade}: Failed");
        }

    }
}
