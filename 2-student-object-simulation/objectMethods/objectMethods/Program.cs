using constructor;
using System;
using static System.Collections.Specialized.BitVector32;

namespace objectMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student(Input.GetInput("first name"), Input.GetInput("last name"),
                               Input.GetNumbers("year"), Input.GetInput("course"), Input.GetInput("section"),
                               Input.GetNumbers("midterm grade"), Input.GetNumbers("final grade"));

            Student.introduceSelf(student1.firstName, student1.lastName, student1.year, student1.course, student1.section);
            Console.WriteLine($"Grade:  {Student.evaluateGrade(student1.midtermGrade, student1.finalGrade)}");
        }
    }
}