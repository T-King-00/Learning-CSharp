using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Delegates
{
    // this example demonstrates how to use delegates to sort a list of customers based on their age.
    class testClass
    {
        public delegate int CompareCustomers(Customers c1, Customers c2);
        public static void Main(string[] args)
        {
            Random random = new Random();
            List<Customers> customers = new List<Customers>();
            for (int i = 0 ; i < 10; i++)
            {
                int age = random.Next(18, 65); // Random age between 18 and 65
                string id =random.Next(10000,999999999).ToString(); // Generate a unique ID
                customers.Add(new Customers(id, age));
            }
            customers.ForEach(c => Console.WriteLine($"ID: {c.id}, Age: {c.age}"));
            /*  "**Compare c2's age to c1's age`. Return:
                -1 if c2.age < c1.age
                0 if c2.age == c1.age
                1 if c2.age > c1.age"
            */
            // ascending .

            // We  use a delegate here to compare the customers based on their age.
            //CompareCustomers compareCustomers = (c1,c2) => c1.age.CompareTo(c2.age);

            // or Instead of defining a custom delegate type, you can use a delegate to achieve the same result with less code:Func
             Func<Customers,Customers,int> compareCustomers= (c1, c2) => c1.age.CompareTo(c2.age);
            customers.Sort( (c1,c2) => compareCustomers( c1, c2)) ;


            Console.WriteLine( "After sorting" );
            customers.ForEach(c => Console.WriteLine($"ID: {c.id}, Age: {c.age}"));

        }





    }
    internal class Customers
    {
        public string id { get; set; }
        public int age { get; set; }

        public Customers(string id,int age)
        {
            this.id= id;
            this.age = age;

        }
    }
}
