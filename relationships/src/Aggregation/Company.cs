namespace Aggregation;

public class Company
{
    public int CompanyId { get; set; }
    public string CompanyName { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }

    public List<Branch> Branches { get; set; } = new();

    public void ConfigureModel()
    {
        // ...
    }
}


