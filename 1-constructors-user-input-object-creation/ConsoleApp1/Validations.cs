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
                Input.Message("This field cannot be empty or whitespace.  Press any key to try again.");
                return false;
            }
            else
                return true;
        }

        public static bool ValidateName(string name)
        {
            if (name.Length < 2)
            {
                Input.Message("Input is too short.  Press any key to try again.");
                return false;
            }
            else if (int.TryParse(name, out int n))
            {
                Input.Message("Name cannot be numbers.  Press any key to try again.");
                return false;
            }
            else
            {
                Input.Message($"{name} is saved. Press any key to continue.");
                return true;
            }
        }

        public static bool ValidateAge(string age)
        {
            int a;

            if (!int.TryParse(age, out a))
            {
                Input.Message("Age must be a valid number.  Press any key to try again.");
                return false;
            }

            else if (a < 0 || a > 120)
            {
                Input.Message("Age must be between 0 and 120.  Press any key to try again.");
                return false;
            }
            else
            {
                Input.Message($"{age} is saved. Press any key to continue.");
                return true;
            }
        }
    }
}
