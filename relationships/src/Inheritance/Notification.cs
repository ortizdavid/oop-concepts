namespace Inheritance;

public class Notification
{
    public string Recipient { get; set; }
    public string Message { get; set; }

    public virtual void Send()
    {
        Console.WriteLine($"Sending notification to {Recipient}: {Message}");
    }
}