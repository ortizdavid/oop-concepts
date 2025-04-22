namespace Association;

public class Permission
{
    public int PermissionId { get; set; }
    public string PermissionName { get; set; }
    public string Code { get; set; }

    public void ConfigureModel()
    {
        // ...
    }
}
