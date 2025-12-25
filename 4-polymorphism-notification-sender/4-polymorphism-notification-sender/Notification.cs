using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace _4_polymorphism_notification_sender
{
    internal class Notification
    {
        public static string PersonalizeName(string template, string name) => template.Replace("{name}", name);

        public static string GreetingEmail { get; } =
            "Subject: Welcome to CatConnect" +
            "\n\nHello {name}," +
            "\n\tWelcome to CatConnect — your place for cat care tips, local cat events, and connecting with fellow cat lovers. Complete your profile to get started." +
            "\n\n— The CatConnect Team";

        public static string VerifyEmail { get; } =
            "Subject: Welcome to CatConnect" +
            "\n\nHi {name}," +
            "\n\tUse code 4821 to verify your account. If you did not request this, please ignore this message." +
            "\n\n— CatConnect Security";

        public static string InvoiceEmail { get; } =
            "Subject: Welcome to CatConnect" +
            "\n\nHi {name}," +
            "\n\tYour invoice for the past month is now available. View and pay your invoice at your CatConnect account." + 
            "\n\n\tThanks for being part of CatConnect, Billing Team";

        public static string VerifySMS { get; } = "CatConnect code: 4821. Enter this in the app to verify your account.";

        public static string ReminderSMS { get; } = "Reminder: Cat Yoga starts at 6:00 PM today at the Downtown Cat Cafe.";

        public static string ConfirmationSMS { get; } = "Confirm your spot for Cat Adoption Day on April 12. Reply YES to confirm or NO to cancel.";

        public static string MessagePush { get; } = "Mitsy sent you a message: \"Want to join tonight's meetup?\" Open CatConnect to reply.";

        public static string EventPush { get; } = "Your event \"Cat Yoga\" starts in 30 minutes. Head to the Downtown Cat Cafe.";

        public static string PromotionPush { get; } = "Limited-time: Get 20% off cat toys today. Tap to claim your reward in CatConnect.";

    }

    class Receiver
    {
        public string Name { get; set; }
        public string Message { get; set; }

        public Receiver(string name, string message) 
        {
            this.Name = name;
            this.Message = message;
        }

        public virtual bool SendNotification()
        {
            Console.WriteLine($"Here is what the notification looks like:   \n\n{Notification.PersonalizeName(Message, Name)}.");
            if (Get.AskToContinue($"Are you sure you want to send it to {Name}?"))
                return true;
            else
                return false; ;
        }

    }

    class EmailReceiver : Receiver
    {
        public string EmailAddress { get; set; }

        public EmailReceiver(string name, string message, string emailAddress) : base (name, message)
        {
            this.EmailAddress = emailAddress;
        }

        public override bool SendNotification()
        {
            Console.WriteLine($"Here is what the email looks like:   \n\n{Notification.PersonalizeName(Message, Name)}\n\n");
            
            if (Get.AskToContinue($"Are you sure you want to send it to {EmailAddress}?"))
                return true;
            else
                return false;
        }
    }

    class SMSReceiver : Receiver
    {
        public string PhoneNumber { get; set; }

        public SMSReceiver(string name, string message, string phoneNumber) : base(name, message)
        {
            this.PhoneNumber = phoneNumber;
        }

        public override bool SendNotification()
        {
            Console.WriteLine($"Here is what the SMS looks like:   \n\n{Notification.PersonalizeName(Message, Name)}\n\n");
            if (Get.AskToContinue($"Are you sure you want to send it to {PhoneNumber} owned by {Name}?"))
                return true;
            else
                return false;
        }
    }

    class PushReceiver : Receiver
    {
        public string DeviceId { get; set; }

        public PushReceiver(string name, string message, string deviceId) : base(name, message)
        {
            this.DeviceId = deviceId;
        }

        public override bool SendNotification()
        {
            Console.WriteLine($"Here is what the push notification looks like:   \n\n{Notification.PersonalizeName(Message, Name)}\n\n");

            if (Get.AskToContinue($"Are you sure you want to send it to {DeviceId} owned by {Name}?"))
                return true;
            else
                return false;
        }
    }

}
