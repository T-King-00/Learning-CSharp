using System;
using System.Globalization;
using System.Threading;

namespace LearnCSharp.Polymorphism;

public class Appliance
{
    public string SerialNumber { get; set; }



    public Appliance(string serialNumber)
    {
        this.SerialNumber = serialNumber;   
    }

    
    public virtual string Start()
    {
        return "Appliance is starting";
    }
    
    public virtual bool CanRunUnattended()
    {
        return true;
    }

    public void RunAppliance(Appliance appliance)
    {
        if (CanRunUnattended())
        {
            Console.WriteLine("Running unattended");
        }
        else
        {
            
            Console.WriteLine("Supervision required");

        }
    }

    
}