namespace Association;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool IsActive { get; set; }
    public List<Role> Roles { get; set; }

    public void ConfigureModel()
    {
        // ...
    }
}
