using System;
using LearnCSharp.Delegates;

namespace LearnCSharp.AdvancedDelegates_WEEK4;



public class Counter:IDisposable
{
    private int total;
    private int threshold;
    public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
    public void Dispose()
    {
        
    }

    public Counter(int threshold)
    {
        this.threshold = threshold;
    }

    public void Add(int value)
    {
        total += value;
        Console.WriteLine($"Current total value is : {total}");
        if (total >= threshold)
        {
            var e = new ThresholdReachedEventArgs()
            {
                threshold = threshold,
                TimeReached = DateTime.Now
            };
            
            
            OnThresholdReached(e);
        }
    }

    protected virtual void OnThresholdReached(ThresholdReachedEventArgs args)
    {
        ThresholdReached?.Invoke(this, args);
    }

}

public class program
{
    public static void Counter_ThresholdReached(object? sender,ThresholdReachedEventArgs e)
    {
        Console.WriteLine($"Counter got threshold reached");
        Environment.Exit(0);
        
    }
    public static void Main00(string[] args)
    {
        using (Counter counterObj = new Counter(100))
        {
            //main program is subscribed to counter  event
            
            counterObj.ThresholdReached+=Counter_ThresholdReached;
            
            Console.WriteLine("Press 'a' to add 1 to the counter or 'q' to quit.");

            while (true)
            {
                var key = Console.ReadKey(true).KeyChar;
                if (key == 'a')
                {
                    counterObj.Add(1);
                }
                else if (key == 'q')
                {
                    break;
                }
                
                
                
            }
         
            counterObj.ThresholdReached-=Counter_ThresholdReached;

        }
      
     

    }

    
}