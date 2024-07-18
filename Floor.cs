public class Floor
{
    public int Number { get; private set; }
    public List<Slot> Slots { get; private set; }

    public Floor(int number, int slotsPerFloor)
    {
        Number = number;
        Slots = new List<Slot>();
        for (int i = 1; i <= slotsPerFloor; i++)
        {
            string type = (i == 1) ? "TRUCK" : (i <= 3) ? "BIKE" : "CAR";
            Slots.Add(new Slot(i, type));
        }
    }

    public Slot? GetFirstAvailableSlot(string vehicleType)
    {
        return Slots.FirstOrDefault(s => s.Type == vehicleType && s.IsFree);
    }

    public bool UnparkVehicle(int slotNumber)
    {
        var slot = Slots.FirstOrDefault(s => s.Number == slotNumber && !s.IsFree);
        if (slot != null)
        {
            slot.UnparkVehicle();
            return true;
        }
        return false;
    }

    public int GetFreeCount(string vehicleType)
    {
        return Slots.Count(s => s.Type == vehicleType && s.IsFree);
    }

    public List<int> GetFreeSlots(string vehicleType)
    {
        return Slots.Where(s => s.Type == vehicleType && s.IsFree).Select(s => s.Number).ToList();
    }

    public List<int> GetOccupiedSlots(string vehicleType)
    {
        return Slots.Where(s => s.Type == vehicleType && !s.IsFree).Select(s => s.Number).ToList();
    }
}
