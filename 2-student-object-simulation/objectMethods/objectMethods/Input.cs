using System;
using System.Collections.Generic;
using System.Text;

namespace constructor
{
    internal class Input
    {
        public static void Message(string message)
        {
            Console.Write($"{message}");
            Console.ReadLine();
            Console.Clear();
        }

        public static string GetInput(string field)
        {
            string? input = string.Empty;
            bool isValidInput = false;

            do
            {
                Console.Write($"Enter {field}:    ");
                input = Console.ReadLine();

                if (Validations.NullCheck(input))
                {
                    if (Validations.ValidateCharacters(input, field))
                        isValidInput = true;
                    else
                        continue;
                }
            } while (!isValidInput);

            if (string.Equals(field, "section"))
                return input.Substring(0, 1).ToUpper();
            else
                return input;
        }

        public static int GetNumbers(string field)
        {
            string? numberInput = string.Empty;
            bool isValidNumber = false;

            do
            {
                Console.Write($"Enter {field}:    ");
                numberInput = Console.ReadLine();

                if (Validations.NullCheck(numberInput))
                {
                    if (Validations.ValidateNumbers(numberInput, field))
                        isValidNumber = true;
                }

            } while (!isValidNumber);

            return int.Parse(numberInput);
        }
    }
}
