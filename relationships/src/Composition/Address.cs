namespace Composition;

public class Address
{
    public string State { get; set; }
    public string City { get; set; }
    public string District { get; set; }
    public string Street { get; set; }

    public override string ToString()
    {
        return $"{Street}, {District}, {City} - {State}";
    }
}
