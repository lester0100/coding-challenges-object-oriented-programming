using System;

namespace constructor
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Person person = new Person( firstName: Input.GetName("first"), lastName: Input.GetName("last"), Input.GetAge());

            Console.WriteLine($"Your name is {person.FirstName} {person.LastName}.\nYou are {person.Age} years old.");
        }
    }
}