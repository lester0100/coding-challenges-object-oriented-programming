using System;
using System.Collections.Generic;
using System.Text;

namespace constructor
{
    internal class Input
    {
        public static void Message(string message)
        {
            Console.WriteLine($"{message}");
            Console.ReadLine();
            Console.Clear();
        }

        public static string GetName(string n)
        {
            string? name = string.Empty;
            bool isValidName = false;

            do
            {
                Console.Write($"Enter {n} Name:    ");
                name = Console.ReadLine();

                if (Validations.NullCheck(name))
                {
                    if (Validations.ValidateName(name))
                        isValidName = true;
                    else
                        continue;
                }
            } while (!isValidName);

            return name;
        }

        public static int GetAge()
        {
            string? ageInput = string.Empty;
            bool isValidAge = false;

            do
            {
                Console.Write("Enter Age:    ");
                ageInput = Console.ReadLine();

                if (Validations.NullCheck(ageInput))
                {
                    if (Validations.ValidateAge(ageInput))
                        isValidAge = true;
                }

            } while (!isValidAge);

            return int.Parse(ageInput);
        }
    }
}
