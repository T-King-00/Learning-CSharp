using System;

namespace LearnCSharp.IComparable;

public class Program
{
    public static void Main0101(string[] args)
    {
        Person p1 = new Person();
        p1.age=24;
        p1.name="mike";
        
        Person p2 = new Person();
        p2.age = 20;
        p2.name = "john";
        
        int result =p1.CompareTo(p2);
        printConsoleMessages(p1, p2, result);

        Person p3 = new();
        p3.age = 18;
        p3.name = "moka";

        int result2 = p3.CompareTo(p1);
        printConsoleMessages(p3, p1, result2);


    


    }

    public static void printConsoleMessages(Person obj1, Person obj2, int result)
    {
        if (result < 0)
            Console.WriteLine($"{obj1.name} (age {obj1.age}) is younger than {obj2.name} (age {obj2.age})");
        else if (result > 0)
            Console.WriteLine($"{obj1.name} (age {obj1.age}) is older than {obj2.name} (age {obj2.age})");
        else
            Console.WriteLine($"{obj1.name} (age {obj1.age}) is same age  as {obj2.name} (age {obj2.age})");

    }
}