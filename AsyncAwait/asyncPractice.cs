using System;
using System.Threading.Tasks;


var t1=  DoSomethingElse();
var t2=  DoSomething();

var x = Task.WhenAny(t1, t2);
Console.ReadLine();





//use async when the function needs to await something to be finished.
async Task DoSomething()
{
    await Task.Delay(100);
    Console.WriteLine("Welcome to the DoSomething method ");
         
}

async Task DoSomethingElse()
{
    long i = 0;
    while (true)
    {
        i++;
        Console.WriteLine("Task 2"+ "Calculating i "+i);
        await Task.Delay(10);
        if (i == 90)
        {
            break;
        }
    }
        
}




    