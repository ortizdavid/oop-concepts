namespace Composition; 

public class HealthData
{
    public string BloodType { get; set; }
    public float Height { get; set; }
    public float Weight { get; set; }
    public string BloodPressure { get; set; }
    public bool IsSmoker { get; set; }
    public bool HasAllergies { get; set; }

    public override string ToString()
    {
        return $"Blood: {BloodType}, Height: {Height}m, Weight: {Weight}kg, Pressure: {BloodPressure}, Smoker: {IsSmoker}, Allergies: {HasAllergies}";
    }
}
