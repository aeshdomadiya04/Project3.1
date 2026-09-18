using System;

class Vehicle
{
    protected string vehicleNumber;
    protected string modelName;

    // Base class constructor
    public Vehicle(string number, string model)
    {
        vehicleNumber = number;
        modelName = model;
    }
}

class Car : Vehicle
{
    private string carType;

    // Derived class constructor
    public Car(string number, string model, string type)
        : base(number, model)
    {
        carType = type;
    }

    // Method to display car details
    public void DisplayDetails()
    {
        Console.WriteLine("Vehicle Number: " + vehicleNumber);
        Console.WriteLine("Model Name: " + modelName);
        Console.WriteLine("Car Type: " + carType);
    }
}

class P6
{
    static void Main()
    {
        Car car = new Car("GJ03AB1234", "Swift", "Hatchback");

        car.DisplayDetails();

        Console.WriteLine("=========================");
        Console.WriteLine("Name: Aesh Domadiya");
        Console.WriteLine("Enrollment no.: 24SOECE11008");
    }
}