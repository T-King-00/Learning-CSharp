using System;
using System.Collections.Generic;

namespace LearnCSharp.Polymorphism;

public class program
{
    public static void Main(string[] args)
    {
        List<Appliance> appliances = new List<Appliance>();
        appliances.Add(new WashingMachine("123456789", 3));
        
        foreach (var app in appliances)
        {
            Console.WriteLine( app.Start());

            app.RunAppliance(app);
        }
        
        Appliance appliance = new WashingMachine("123456789", 3);
        Console.WriteLine(appliance.CanRunUnattended());
        Console.WriteLine( appliance.Start());

        appliance.RunAppliance(appliance);
        
        
    }
}