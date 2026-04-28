using System;

namespace LearnCSharp.interfaces;

public class Program
{
    public static void Main0111(string[] args)
    {
        ElectricScooter electricScooter = new ElectricScooter(new(2026,1,1),100,4000);
        electricScooter.WriteValues();
        Console.WriteLine(   electricScooter.ScheduleMaintenance());
        Console.WriteLine("************************************");
        Vehicle vehicle = new ElectricScooter(new(2026, 10, 10), 240,500);
        Console.WriteLine(vehicle.ScheduleMaintenance());

    }
}