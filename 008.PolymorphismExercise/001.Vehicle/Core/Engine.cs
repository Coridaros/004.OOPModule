using Vehicle.Core.Interfaces;
using Vehicle.IO;
using Vehicle.IO.Interfaces;
using Vehicle.Models;
using Vehicle.Models.Interfaces;

namespace Vehicle.Core;

public class Engine : IEngine
{
    private readonly IReader reader;
    private readonly IWritter writter;

    public Engine(IReader reader, IWritter writter)
    {
        this.reader = reader;
        this.writter = writter;
    }
    public void Run()
    {
        string[] carTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string[] truckTokens = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

        IVehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
        IVehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));

        int n = int.Parse(reader.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string command = input[0];
            string vehicleType = input[1];

            if (command == "Drive")
            {
                double distance = double.Parse(input[2]);
                if (vehicleType == "Car")
                {
                    if (car.Drive(distance))
                    {
                        Console.WriteLine($"Car travelled {distance} km");
                    }
                    else
                    {
                        Console.WriteLine("Car needs refueling");
                    }
                }
                else
                {
                    if (truck.Drive(distance))
                    {
                        writter.WriteLine($"Truck travelled {distance} km");
                    }
                    else
                    {
                        writter.WriteLine("Truck needs refueling");
                    }
                }
            }
            else if (command == "Refuel")
            {
                double amount = double.Parse(input[2]);
                if (vehicleType == "Car")
                {
                    car.Refuel(amount);
                }
                else
                {
                    truck.Refuel(amount);
                }
            }
        }

        writter.WriteLine(car.ToString());
        writter.WriteLine(truck.ToString());
    }
}
