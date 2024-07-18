public class Slot
{
    public int Number { get; private set; }
    public string Type { get; private set; }
    public Vehicle? ParkedVehicle { get; private set; } 
    public bool IsFree => ParkedVehicle == null;

    public Slot(int number, string type)
    {
        Number = number;
        Type = type;
        ParkedVehicle = null; 
    }

    public void ParkVehicle(Vehicle vehicle)
    {
        ParkedVehicle = vehicle;
    }

    public void UnparkVehicle()
    {
        ParkedVehicle = null;
    }
}
