
//1) null value assignment for a reference type
// null forgiving for a reference variable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using LearnCSharp.Null;

public class Program1
{
    public static void Main0(string[] args)
    {
           
            //1)NULL forgiving
            string name0 = null;
            string ? name = null;
            Console.WriteLine(name?.ToLower());
    
            //2) Null null‑coalescing operator : ?? "do this if var equals null"
            string ? displayName = name ?? "default name";

            //3) null conditional operator : ?. "assign this or do this  if var is not null"
            string ? displayName2 = name?.Length > 0 ? name : null;

            //4) null conditional operator in if statement
            Product ?product=null;
            if(product?.Name?.Length > 0)
            {
                Console.WriteLine(product.Name.Length);
            }
            //instead of writing this which throws exception states tht .
            //Object reference not set to an instance of an object.

            if (product.Name.Length > 0)
            {
                Console.WriteLine(product.Name.Length);
            }

            //5)null conditoion expression assignment c#14
            List<Product> ? products = null;
            (products ??=new List<Product>()).Add(new Product("product1",100));


        
    }
}

