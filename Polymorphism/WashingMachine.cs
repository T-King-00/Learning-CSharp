namespace LearnCSharp.Polymorphism;

public class WashingMachine : Appliance
{
    public int DrumSize{get;set;}
    
    public WashingMachine(string serialNumber,int drumSize) : base(serialNumber)
    {
        this.DrumSize = drumSize;    
    }

    public override string Start()
    {
        return "washing machine is starting";
    }
   
    
}