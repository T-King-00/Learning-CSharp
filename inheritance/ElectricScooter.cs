using System;

namespace LearnCSharp.interfaces;

public class ElectricScooter : Vehicle
{
    public double BatteryCapacity { get; set;}
    
    public ElectricScooter(DateOnly manufactureDate, double maxSpeed,double batteryCapacity) : base(manufactureDate, maxSpeed)
    {
        this.BatteryCapacity = batteryCapacity;
        Console.WriteLine("ElectricScooter created");
    }

    public void WriteValues()
    {
      
        Console.WriteLine("Batter Capacity: "+ this.BatteryCapacity);
        Console.WriteLine("Max Speed: "+ this.MaxSpeed);
        Console.WriteLine("Manufacture Date: "+ this.ManufactureDate);
    }

    public override string ScheduleMaintenance()
    {
        return ("ElectricScooter maintenance is scheduled");
    }   
}