namespace Inheritance;

public class EmailNotification : Notification
{
    public string Subject { get; set; }

    public override void Send()
    {
        Console.WriteLine($"Sending Email to {Recipient} | Subject: {Subject} | Message: {Message}");
    }
}
