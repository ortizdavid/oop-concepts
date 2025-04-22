namespace Aggregation;

public class Room
{
    public int RoomId { get; set; }
    public string RoomName { get; set; }
    public string Number { get; set; }
    public int Capacity { get; set; }

    public Office Office { get; set; }

    public void ConfigureModel()
    {
        // ...
    }
}
