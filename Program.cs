// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        ParkingLot? parkingLot = null;
        string command;
        while ((command = Console.ReadLine()) != "exit")
        {
            var parts = command.Split(' ');
            switch (parts[0])
            {
                case "create_parking_lot":
                    string parkingLotId = parts[1];
                    int numberOfFloors = int.Parse(parts[2]);
                    int slotsPerFloor = int.Parse(parts[3]);
                    parkingLot = new ParkingLot(parkingLotId, numberOfFloors, slotsPerFloor);
                    Console.WriteLine($"Created parking lot with {numberOfFloors} floors and {slotsPerFloor} slots per floor");
                    break;

                case "park_vehicle":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Parking lot has not been created yet.");
                        break;
                    }
                    string vehicleType = parts[1];
                    string regNo = parts[2];
                    string color = parts[3];
                    var vehicle = new Vehicle(vehicleType, regNo, color);
                    var ticket = parkingLot.ParkVehicle(vehicle);
                    if (ticket == null)
                    {
                        Console.WriteLine("Parking Lot Full");
                    }
                    else
                    {
                        Console.WriteLine($"Parked vehicle. Ticket ID: {ticket.Id}");
                    }
                    break;

                case "unpark_vehicle":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Parking lot has not been created yet.");
                        break;
                    }
                    string ticketId = parts[1];
                    if (parkingLot.UnparkVehicle(ticketId))
                    {
                        Console.WriteLine("Unparked vehicle.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Ticket");
                    }
                    break;

                case "display":
                    if (parkingLot == null)
                    {
                        Console.WriteLine("Parking lot has not been created yet.");
                        break;
                    }
                    string displayType = parts[1];
                    string vehicleTypeDisplay = parts[2];
                    switch (displayType)
                    {
                        case "free_count":
                            parkingLot.DisplayFreeCount(vehicleTypeDisplay);
                            break;
                        case "free_slots":
                            parkingLot.DisplayFreeSlots(vehicleTypeDisplay);
                            break;
                        case "occupied_slots":
                            parkingLot.DisplayOccupiedSlots(vehicleTypeDisplay);
                            break;
                    }
                    break;
            }
        }
    }
}
