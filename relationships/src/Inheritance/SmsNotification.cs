namespace Inheritance;

public class SmsNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine($"Sending SMS to {Recipient} | Message: {Message}");
    }
}

