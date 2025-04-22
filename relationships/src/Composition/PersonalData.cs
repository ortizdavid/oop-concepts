namespace Composition;

public class PersonalData
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string IdentNumber { get; set; }
    public string Gender { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName} | ID: {IdentNumber} | Gender: {Gender}";
    }
}


