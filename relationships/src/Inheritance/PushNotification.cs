namespace Inheritance;

public class PushNotification : Notification
{
    public string App { get; set; }

    public override void Send()
    {
        Console.WriteLine($"Sending Push via {App} to {Recipient} | Message: {Message}");
    }
}
