using System;

namespace LearnCSharp.Null;

// ! unary postfix operator = > null-forgiving, or null-suppression
public class practice
{
    public static void Main0(string[] args)
    {
        try
        {
            TestNullConditionExpression();
            
            // List<int>?numbers = null;
            // //this gives warning
            // numbers.Add(1);
            // //so we write it like this 
            // (numbers??= new()).Add(1);
            
            

            
             //forgive me for now, don't give warning about possible null reference.
            /*
             string name =null;
             string copyName = name.Clone().ToString();
             Console.WriteLine(name.GetHashCode());
             //strings are immutable , so we can't change the value of the name variable.
             //it does create another string object.
             name = "tony";
             Console.WriteLine(copyName);*/

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            
        }
      
    }

    public void TestingNull()
    {
        // ? -> makes the variable nullable.
        //nullable integer
        int ? i = null;
        
        //null can be assigned to reference type variables.
        //warning: assignment of an object reference to a nullable type
        //? -> ignores the warning
        string  ? s = null;
        Product  p = null;
    }

    public void TestNullForgivingConcept()
    {
        string ?name =null;
        Console.WriteLine(name ?? "name is null");
        string? displayName = name;

        if (displayName is null )
        {
            Console.WriteLine("displayname variable is null");
            Console.WriteLine(displayName ?? "still null");
            displayName = "new value";
            
        }
    }
    
    public void TestCopyByReferenceConcept()
    {
        //reference type copy the location (reference in memory)
        Product p = new("applle",10);
        Product p2 = p;
        p.Name = "banana";
        Console.WriteLine(p.Name);
        Console.WriteLine(p2.Name);
    }
    
    public void TestWarningForNull()
    {
        string  ? s = null;
        //Console.WriteLine(s.Length);
        
        //smart enough not to give warning.
        if (s is not null)
        {
            Console.WriteLine(s.Length);
        }
        //or
        Console.WriteLine(s!.Length); // ! -> tells compiler to ignore the warning. and that var wont be null for sure.
        
    }
    
    public void TestWarningForNull2()
    {
        Product ? p = null;
        Console.WriteLine(p.Name.Length);

        Product? x = null;
        Console.WriteLine(x!.Name.Length);
        //or 
        if (x.Name.Length>0)
        {
            Console.WriteLine(x.Name.Length);
        }
        //or
        
        
    }
    
    public void TestNullCoalescingOperator()
    {
        string? oldName=null;
        //some code 
        //...
        //null conditional operator
        string newName = oldName ?? "default name" ;
        
        //instead of writing
        if (oldName is not null)
        {
            newName = oldName;
        }
    }
    
    public void TestNullConditionalOperators()
    {
        Product? p=null;
        //instead of writing
        Console.WriteLine(p.Name.Length);
        
        //better that we write 
        if (p?.Name?.Length > 0)
        {
            Console.WriteLine(p.Name.Length);
        }
        
        //instead of writing
        if (p.Name.Length > 0)
        {
            Console.WriteLine(p.Name.Length);
        }
    }

    public void TestNullCoalescingOperator1()
    {
        string name=null;
        name = "tony";
        string newName = name ?? "default name";

    }

    public static void TestNullConditionExpression()
    {
        Product ?p = null;
        //(p ??= new Product("mac",1)).Price = 100;
        //less clear what should happen if product is null.
        //the entire right-hand side is skipped if the left is null.
        p?.Price += 100;

        Console.WriteLine("price is :" + p?.Price);
        //better
        if (p is null)
        { 
            throw new Exception("product is null");
        }
        p.Price += 100;
   
    }
}


class Product(string name, double price)
{
    public  string Name = name ;
    public  double Price = price;
    public  int date { get; set; }

}