using objectMethods;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace constructor
{
    internal class Validations
    {

        public static bool NullCheck(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Input.Message("This field cannot be empty or whitespace. Press any key to try again.");
                return false;
            }
            else
                return true;
        }

        public static bool ValidateCharacters(string str, string field)
        {
            bool isSection = string.Equals(field, "section");
            if (isSection)
            {
                if (str.Length != 1)
                {
                    Input.Message("Section must be a single character. Press any key to try again.");
                    return false;
                }
            }

            int length = isSection ? 1 : 2;

            if (int.TryParse(str, out int n))
            {
                Input.Message("This field cannot be numbers. Press any key to try again.");
                return false;
            }
            else if (str.Length < length)
            {
                if (isSection)
                    Input.Message("Section must be a single character. Press any key to try again.");
                else
                    Input.Message("This field must be at least 2 characters long. Press any key to try again.");
                return false;
            }
            else
            {
                Input.Message($"{str} is saved. Press any key to continue.");
                return true;
            }
        }

        public static bool ValidateNumbers(string num, string field)
        {
            int n;

            if (!int.TryParse(num, out n))
            {
                Input.Message("Invalid number. Press any key to try again.");
                return false;
            }
            else if ((n <= 0 || num.Length != 1) && string.Equals(field, "year"))
            {
                Input.Message("Year must be a single digit from 1 and 9. Press any key to try again.");
                return false;
            }
            else if ((n < 0 || n > 100) && field.Contains("grade"))
            {
                Input.Message("Grade must be between 0 and 100. Press any key to try again.");
                return false;
            }
            else
            {
                Input.Message($"{num} is saved. Press any key to continue.");
                return true;
            }
        }
    }
}
