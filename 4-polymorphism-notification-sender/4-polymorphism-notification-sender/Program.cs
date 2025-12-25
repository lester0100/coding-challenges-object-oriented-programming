
using _4_polymorphism_notification_sender;

bool isContinue = true;

do {
    string notifType = Get.GetType("notif");
    string template = Get.GetMessage(notifType);

    switch (notifType)
    {
        case "email":
            EmailReceiver emailReceiver = new EmailReceiver(Get.GetReceiverName(notifType), template, Get.GetEmailAddress());
            if (emailReceiver.SendNotification())
                Message.Success($"Email sent successfully to {emailReceiver.EmailAddress}.");
            else 
                Message.Invalid($"Failed to send email to {emailReceiver.EmailAddress}.");
            break;

        case "sms":
            SMSReceiver smsReceiver = new SMSReceiver(Get.GetReceiverName(notifType), template, Get.GetPhoneNumber());
            if (smsReceiver.SendNotification())
                Message.Success($"SMS sent successfully to {smsReceiver.PhoneNumber}.");
            else
                Message.Invalid($"Failed to send sms to {smsReceiver.PhoneNumber}.");
            break;

        case "push":
            PushReceiver pushReceiver = new PushReceiver(Get.GetReceiverName(notifType), template, Get.GetDeviceID());
            if (pushReceiver.SendNotification())
                Message.Success($"Push notification sent successfully to {pushReceiver.DeviceId}.");
            else
                Message.Invalid($"Failed to send pish notification to {pushReceiver.DeviceId}.");
            break;
    }

    if (Get.AskToContinue("Do you want to send another notification?"))
        Message.Success("Starting new notification");
    else
    {
        Console.WriteLine("Exiting program. Goodbye!");
        isContinue = false;
    }

} while (isContinue);