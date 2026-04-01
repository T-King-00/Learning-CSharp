using System;
namespace LearnCSharp.interfaces;

public class Vehicle
{
    public DateOnly ManufactureDate { get; set; }
    public double MaxSpeed { get; set; }

    public Vehicle(DateOnly manufactureDate, double maxSpeed)
    {
        this.ManufactureDate = manufactureDate;
        this.MaxSpeed = maxSpeed;
        Console.WriteLine("Vehicle created");
        
    }
    public virtual string ScheduleMaintenance()
    {
        return ("Vehicle maintenance requires supervisor approval");
    }
  
    
    
}