# ParkingLotSystem

This is a command-line application for managing a parking lot system. The parking lot can have multiple floors, and each floor can have different numbers of slots suitable for various types of vehicles (Car, Bike, Truck).

## Features

- Create a parking lot with multiple floors and slots.
- Park and unpark vehicles.
- Display the number of free slots, all free slots, and all occupied slots per floor for a specific vehicle type.
- Generate and manage parking tickets.

## Requirements

- .NET SDK (version 8 or higher)

## Building and Running

1. **Clone the repository:**
    ```bash
    git clone <repository-url>
    cd <repository-directory>
    ```

2. **Build the project:**
    ```bash
    dotnet build
    ```

3. **Run the project:**
    ```bash
    dotnet run
    ```

## Usage

Once the application is running, you can input commands in the following format:

1. **Creating the parking lot:**
    ```plaintext
    create_parking_lot <parking_lot_id> <no_of_floors> <no_of_slots_per_floor>
    ```
    Example:
    ```plaintext
    create_parking_lot PR1234 2 6
    ```

2. **Parking a vehicle:**
    ```plaintext
    park_vehicle <vehicle_type> <reg_no> <color>
    ```
    Example:
    ```plaintext
    park_vehicle CAR KA-01-DB-1234 black
    ```

3. **Unparking a vehicle:**
    ```plaintext
    unpark_vehicle <ticket_id>
    ```
    Example:
    ```plaintext
    unpark_vehicle PR1234_1_4
    ```

4. **Displaying information:**
    ```plaintext
    display <display_type> <vehicle_type>
    ```
    Example:
    ```plaintext
    display free_count CAR
    display free_slots BIKE
    display occupied_slots TRUCK
    ```

5. **Exiting the application:**
    ```plaintext
    exit
    ```

## Example Session

```plaintext
create_parking_lot PR1234 2 6
display free_count CAR
display free_count BIKE
display free_count TRUCK
display free_slots CAR
display free_slots BIKE
display free_slots TRUCK
display occupied_slots CAR
display occupied_slots BIKE
display occupied_slots TRUCK
park_vehicle CAR KA-01-DB-1234 black
park_vehicle CAR KA-02-CB-1334 red
park_vehicle CAR KA-01-DB-1133 black
park_vehicle CAR KA-05-HJ-8432 white
park_vehicle CAR WB-45-HO-9032 white
park_vehicle CAR KA-01-DF-8230 black
park_vehicle CAR KA-21-HS-2347 red
display free_count CAR
display free_count BIKE
display free_count TRUCK
unpark_vehicle PR1234_2_5
unpark_vehicle PR1234_2_5
unpark_vehicle PR1234_2_7
display free_count CAR
display free_count BIKE
display free_count TRUCK
display free_slots CAR
display free_slots BIKE
display free_slots TRUCK
display occupied_slots CAR
display occupied_slots BIKE
display occupied_slots TRUCK
park_vehicle BIKE KA-01-DB-1541 black
park_vehicle TRUCK KA-32-SJ-5389 orange
park_vehicle TRUCK KL-54-DN-4582 green
park_vehicle TRUCK KL-12-HF-4542 green
display free_count CAR
display free_count BIKE
display free_count TRUCK
display free_slots CAR
display free_slots BIKE
display free_slots TRUCK
display occupied_slots CAR
display occupied_slots BIKE
display occupied_slots TRUCK
exit
```
## Code Structure

### Program.cs
- **Description**: Contains the `Main` method and handles user input.

### ParkingLot.cs
- **Description**: Represents the parking lot and contains methods to create floors, add slots, park, and unpark vehicles.

### Floor.cs
- **Description**: Represents a floor in the parking lot and manages the slots on that floor.

### Slot.cs
- **Description**: Represents an individual parking slot.

### Vehicle.cs
- **Description**: Represents a vehicle.

### Ticket.cs
- **Description**: Represents a parking ticket.
