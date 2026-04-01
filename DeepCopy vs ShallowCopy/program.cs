using System;

namespace LearnCSharp.DeepCopy_vs_ShallowCopy;

public class program
{
    public static void Main0000(string[] args)
    {
        Person p1 = new Person();
        p1.age=24;
        p1.name="mike";
        
        Person p2 = new Person();
        p2.age = 20;
        p2.name = "john";

        //shallow copy
        Person copy = p1;
        copy.age = 25;
        Console.WriteLine("shallow copy");
        Console.WriteLine(">" + p1.name + " " + p1.age + "  ");
        Console.WriteLine(">" + copy.name + " " + copy.age + "  ");

        //deep copy
        Console.WriteLine("deep copy");
        Person deepCopy = new Person(p2);
        deepCopy.age = 50;
        Console.WriteLine(">" + p2.name + " " + p2.age + "  ");
        Console.WriteLine(">" + deepCopy.name + " " + deepCopy.age + "  ");


    }

   
}