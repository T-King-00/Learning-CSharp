namespace LearnCSharp.Polymorphism;

public class Refrigerator: Appliance
{
    bool HasFreezer {get;set;}
    
    public Refrigerator(string serialNumber,bool hasFreezer) : base(serialNumber)
    {
        this.HasFreezer = hasFreezer;
    }
    
    public override string Start()
    {
        return "refrigerator machine is starting";
    }
    
  
}