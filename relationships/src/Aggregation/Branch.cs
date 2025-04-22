namespace Aggregation;

public class Branch
{
    public int BranchId { get; set; }
    public string BranchName { get; set; }
    public string Address { get; set; }

    public Company Company { get; set; }
    public List<Office> Offices { get; set; } = new();

    public void ConfigureModel()
    {
        // ...
    }
}
