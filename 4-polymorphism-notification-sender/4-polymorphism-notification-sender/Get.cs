using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _4_polymorphism_notification_sender
{
    static class Get
    {
        public static string GetType(string input)
        {
            bool isValidType = false;
            string? inputType;

            string opt1 = String.Empty;
            string opt2 = String.Empty;
            string opt3 = String.Empty;

            if (String.Equals(input, "notif", StringComparison.OrdinalIgnoreCase))
            {
                opt1 = "Email";
                opt2 = "SMS";
                opt3 = "Push";
            }
            else if (String.Equals(input, "email", StringComparison.OrdinalIgnoreCase))
            {
                opt1 = "Greeting";
                opt2 = "Verify";
                opt3 = "Invoice";
            }
            else if (String.Equals(input, "sms", StringComparison.OrdinalIgnoreCase))
            {
                opt1 = "Verify";
                opt2 = "Reminder";
                opt3 = "Confirmation";
            }
            else if (String.Equals(input, "push", StringComparison.OrdinalIgnoreCase))
            {
                opt1 = "Message";
                opt2 = "Event";
                opt3 = "Promotion";
            }

            do
            {
                Console.Write("What notification you want to send?\n" +
                    "-  " + opt1 + "\n" +
                    "-  " + opt2 + "\n" +
                    "-  " + opt3 + "\n\n" +
                    "Your input:  ");
                inputType = Console.ReadLine().Trim().ToLower();

                if (Validations.ValidateType(inputType, opt1, opt2, opt3))
                {
                    Message.Success($"You have entered {inputType}");
                    isValidType = true;
                }
            }

            while (!isValidType);

            return inputType;


        }

        public static string GetReceiverName(string notifType)
        {
            bool isValidName = false;
            string? inputName;

            do
            {
                Console.Write("Enter receiver's name: ");
                inputName = Console.ReadLine().Trim();

                if ((!Validations.NullCheck(inputName)) && (!Validations.IntegerCheck(inputName)) && Validations.ValidateLength(inputName, 2))
                {
                    Message.Success($"You are about to send {notifType} to {inputName}");
                    isValidName = true;
                }

            } while (!isValidName);

            return inputName;
        }

        public static string GetEmailAddress()
        {
            bool isValidEmailAddress = false;
            string? inputEmailAddress;

            do
            {
                Console.Write("Enter receiver's email address: ");
                inputEmailAddress = Console.ReadLine().Trim();

                if (!Validations.NullCheck(inputEmailAddress) && Validations.ValidateLength(inputEmailAddress, 5) && Validations.ValidateEmailAddress(inputEmailAddress))
                {
                    Message.Success($"You are about to send email to {inputEmailAddress}");
                    isValidEmailAddress = true;
                }

            } while (!isValidEmailAddress);

            return inputEmailAddress;
        }

        public static string GetPhoneNumber()
        {
            bool isValidPhoneNumber = false;
            string? inputPhoneNumber;

            do
            {
                Console.Write("Enter receiver's phone number: ");
                inputPhoneNumber = Console.ReadLine().Trim();

                if (!Validations.NullCheck(inputPhoneNumber) && Validations.ValidateLength(inputPhoneNumber, 11) && Validations.ValidatePhoneNumber(inputPhoneNumber))
                {
                    Message.Success($"You are about to send SMS to {inputPhoneNumber}");
                    isValidPhoneNumber = true;
                }

            } while (!isValidPhoneNumber);

            return inputPhoneNumber;
        }

        public static string GetDeviceID()
        {
            bool isValidDeviceID = false;
            string? inputDeviceID;

            do
            {
                Console.Write("Enter receiver's device ID: ");
                inputDeviceID = Console.ReadLine().Trim();

                if (!Validations.NullCheck(inputDeviceID) && Validations.ValidateLength(inputDeviceID, 5))
                {
                    if (int.TryParse(inputDeviceID, out int n))
                    {
                        Message.Success($"You are about to send Push notification to device ID: {inputDeviceID}");
                        isValidDeviceID = true;
                    }
                    else
                        Message.Invalid("Device ID should be numeric.");
                }

            } while (!isValidDeviceID);

            return inputDeviceID;
        }

        public static string GetMessage(string notifType)
        {
            string message = String.Empty;
            string messageType = Get.GetType(notifType);

            if (String.Equals(notifType, "email", StringComparison.OrdinalIgnoreCase))
            {
                if (String.Equals(messageType, "greeting", StringComparison.OrdinalIgnoreCase))
                    message = Notification.GreetingEmail;
                else if (String.Equals(messageType, "verify", StringComparison.OrdinalIgnoreCase))
                    message = Notification.VerifyEmail;
                else if (String.Equals(messageType, "invoice", StringComparison.OrdinalIgnoreCase))
                    message = Notification.InvoiceEmail;
            }

            else if (String.Equals(notifType, "sms", StringComparison.OrdinalIgnoreCase))
            {
                if (String.Equals(messageType, "verify", StringComparison.OrdinalIgnoreCase))
                    message = Notification.VerifySMS;
                else if (String.Equals(messageType, "reminder", StringComparison.OrdinalIgnoreCase))
                    message = Notification.ReminderSMS;
                else if (String.Equals(messageType, "confirmation", StringComparison.OrdinalIgnoreCase))
                    message = Notification.ConfirmationSMS;
            }

            else if (String.Equals(notifType, "push", StringComparison.OrdinalIgnoreCase))
            {
                if (String.Equals(messageType, "message", StringComparison.OrdinalIgnoreCase))
                    message = Notification.MessagePush;
                else if (String.Equals(messageType, "event", StringComparison.OrdinalIgnoreCase))
                    message = Notification.EventPush;
                else if (String.Equals(messageType, "promotion", StringComparison.OrdinalIgnoreCase))
                    message = Notification.PromotionPush;
            }

            return message;
        }

        public static bool AskToContinue(string message)
        {
            bool isValidInput = false;
            string? input;

            do
            {
                Console.Write($"{message}? (Yes/No):    ");
                input = Console.ReadLine().Trim().ToLower();

                if (!Validations.NullCheck(input) && !Validations.IntegerCheck(input))
                {
                    if (String.Equals(input, "yes", StringComparison.OrdinalIgnoreCase)
                        || String.Equals(input, "no", StringComparison.OrdinalIgnoreCase))
                        isValidInput = true;
                    else
                        Message.Invalid("Please enter Yes or No.");
                }

            } while (!isValidInput);

            return String.Equals(input, "Yes", StringComparison.OrdinalIgnoreCase) ? true : false;
        }
    }
}
