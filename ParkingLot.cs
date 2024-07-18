using System;
using System.Collections.Generic;

public class ParkingLot
{
    public string Id { get; private set; }
    public List<Floor> Floors { get; private set; }

    public ParkingLot(string id, int numberOfFloors, int slotsPerFloor)
    {
        Id = id;
        Floors = new List<Floor>();
        for (int i = 1; i <= numberOfFloors; i++)
        {
            Floors.Add(new Floor(i, slotsPerFloor));
        }
    }

    public Ticket? ParkVehicle(Vehicle vehicle)
    {
        foreach (var floor in Floors)
        {
            Slot? slot = floor.GetFirstAvailableSlot(vehicle.Type);
            if (slot != null)
            {
                slot.ParkVehicle(vehicle);
                return new Ticket(Id, floor.Number, slot.Number, vehicle);
            }
        }
        return null;
    }

    public bool UnparkVehicle(string ticketId)
    {
        var parts = ticketId.Split('_');
        if (parts.Length != 3) return false;

        if (!int.TryParse(parts[1], out int floorNumber) || !int.TryParse(parts[2], out int slotNumber))
            return false;

        if (floorNumber > Floors.Count || slotNumber > Floors[floorNumber - 1].Slots.Count)
            return false;

        return Floors[floorNumber - 1].UnparkVehicle(slotNumber);
    }

    public void DisplayFreeCount(string vehicleType)
    {
        foreach (var floor in Floors)
        {
            Console.WriteLine($"No. of free slots for {vehicleType} on Floor {floor.Number}: {floor.GetFreeCount(vehicleType)}");
        }
    }

    public void DisplayFreeSlots(string vehicleType)
    {
        foreach (var floor in Floors)
        {
            Console.WriteLine($"Free slots for {vehicleType} on Floor {floor.Number}: {string.Join(",", floor.GetFreeSlots(vehicleType))}");
        }
    }

    public void DisplayOccupiedSlots(string vehicleType)
    {
        foreach (var floor in Floors)
        {
            Console.WriteLine($"Occupied slots for {vehicleType} on Floor {floor.Number}: {string.Join(",", floor.GetOccupiedSlots(vehicleType))}");
        }
    }
}
