public class Vehicle
{
    public string Type { get; private set; }
    public string RegistrationNumber { get; private set; }
    public string Color { get; private set; }

    public Vehicle(string type, string registrationNumber, string color)
    {
        Type = type;
        RegistrationNumber = registrationNumber;
        Color = color;
    }
}
