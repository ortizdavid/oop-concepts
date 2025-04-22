namespace Association;

public class Role
{
    public int RoleId { get; set; }
    public string RoleName { get; set; }
    public string Code { get; set; }
    public List<Permission> Permissions { get; set; }

    public void ConfigureModel()
    {
        // ...
    }
}
