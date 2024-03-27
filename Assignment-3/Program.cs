using Assignment_3;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of vehicles
        Car car1 = new Car("X", "Tesla", 2015, 150, 5, "V6", "Automatic", false);
        Truck truck1 = new Truck("Tundra", "Toyota", 2019, 80, 3, "Pickup", true);
        Motorcycle bike1 = new Motorcycle("CB1000R", "Honda", 2021, 50, 1000, "Gas", true);

        // Displaying details of vehicles
        Console.WriteLine("Car Details:");
        car1.DisplayDetails();
        Console.WriteLine("\nTruck Details:");
        truck1.DisplayDetails();
        Console.WriteLine("\nMotorcycle Details:");
        bike1.DisplayDetails();

        //Testing RentalAgency class
        RentalAgency agency = new RentalAgency(3);
        agency.AddVehicle(car1, 0);
        agency.AddVehicle(truck1, 1);
        agency.AddVehicle(bike1, 2);

        // Renting a vehicle
        Console.WriteLine("\nRenting Vehicle:");
        agency.RentVehicle(1, 1);

        // Removing a vehicle
        agency.RemoveVehicle(1);

    }
}