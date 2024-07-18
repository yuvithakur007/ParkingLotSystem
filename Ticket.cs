public class Ticket
{
    public string Id { get; private set; }
    public Vehicle ParkedVehicle { get; private set; }

    public Ticket(string parkingLotId, int floorNumber, int slotNumber, Vehicle vehicle)
    {
        Id = $"{parkingLotId}_{floorNumber}_{slotNumber}";
        ParkedVehicle = vehicle;
    }
}
