namespace Aggregation;

public class Office
{
    public int OfficeId { get; set; }
    public string OfficeName { get; set; }
    public string Code { get; set; }
    public string Address { get; set; }
    public int Phone { get; set; }

    public Branch Branch { get; set; }
    public List<Room> Rooms { get; set; } = new();

    public void ConfigureModel()
    {
        // ...
    }
}

