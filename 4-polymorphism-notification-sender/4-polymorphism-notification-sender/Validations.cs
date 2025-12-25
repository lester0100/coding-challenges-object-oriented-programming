using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace _4_polymorphism_notification_sender
{
    internal class Validations
    {

        public static bool NullCheck(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                Message.Invalid("This field cannot be empty");
                return true;
            }
            else
                return false;
        }

        public static bool IntegerCheck(string input)
        {
            if (int.TryParse(input, out int n))
            {
                Message.Invalid("Input cannot be a number");
                return true;
            }
            else
                return false;
        }

        public static bool ValidateType(string input, string opt1, string opt2, string opt3)
        {

            if ((!NullCheck(input)) && (!IntegerCheck(input)))
            {
                if (String.Equals(input, opt1, StringComparison.OrdinalIgnoreCase)
                    || String.Equals(input, opt2, StringComparison.OrdinalIgnoreCase)
                    || String.Equals(input, opt3, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
                else
                {
                    Message.Invalid($"Invalid {input} type");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateLength(string input, int minLength)
        {
            if (input.Length < minLength)
            {
                Message.Invalid("Input is too short");
                return false;
            }
            else
                return true;
        }

        public static bool ValidateEmailAddress(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true;
            }
            catch
            {
                Message.Invalid("Invalid email address format");
                return false;
            }
        }

        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            var pattern = @"^(?:\+63|0)9\d{9}$";

            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                Message.Invalid("Invalid phone number format");
                return false;
            }
            else
                return true;
        }
    }

    class Message
    {
        public static void Success(string message)
        {
            Console.Write($"{message}. Press any key continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Invalid(string message)
        {
            Console.Write($"{message}. Press any key to try again.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
