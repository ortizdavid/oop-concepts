namespace Composition;

public class Employee
{
    public int EmployeeId { get; set; }
    public PersonalData PersonalData { get; set; }
    public Address Address { get; set; }
    public HealthData HealthData { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"ID: {EmployeeId}");
        Console.WriteLine($"Personal: {PersonalData}");
        Console.WriteLine($"Address: {Address}");
        Console.WriteLine($"Health: {HealthData}");
    }
}