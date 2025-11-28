using System;
using System.Runtime.InteropServices.JavaScript;

namespace LearnCSharp.Delegates;

public class program
{
    public static void Main(string[] args)
    {
        Flight flight = new Flight();
        
      
        //as flight passenger 
        passenger pass1 = new passenger("mike");
        //we add the method that gonna subscribe to the event.
        flight.OnFlightStatusChanged +=  pass1.subscirbePassenger;

        flight.UpdateStatus("boarding");
        flight.UpdateStatus("delayed boarding");
    }

   
    
}

class passenger
{
    private string name;
    private Flight flightbooked;

    public passenger(string name)
    {
        this.name = name;
    }
    public void subscirbePassenger(string flightNumber, string status)
    {
        Console.WriteLine($"Passenger {this.name} notified: Flight {flightNumber} is now '{status}'.");
        
    }
}

//publisher 
public class Flight
{
    private string FlightStatus = "ontime";
    private DateTime FlightDate = DateTime.Parse("28/11/2025");
    private string FlightNumber = "axy145";
    
    //defines how subscriber will recieve the updates . 
    public delegate void FlightStatusHandler(string flightNumber, string status);
    public event FlightStatusHandler OnFlightStatusChanged;
    
    
    public Flight()
    {
        
    }

    public void UpdateStatus(string newStatus)
    {       
        Console.WriteLine($"[Flight] {FlightNumber} status changed to: {newStatus}");
        
        //if there are subscribers , do so 

        OnFlightStatusChanged?.Invoke(FlightNumber, newStatus);

        
    }
}