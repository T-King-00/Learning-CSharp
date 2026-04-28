using System;
using System.Security.Cryptography;
using LearnCSharp.DeepCopy_vs_ShallowCopy;

namespace LearnCSharp.Records;




public class program
{
    public static void Main(string[] args)
    {

        Person Person1AsARecord = new Person("tony", 23);
        Person1AsARecord= Person1AsARecord with { name = "mike" };

        Person Person2AsARecord = new Person("mike", 24);

        PersonC personAsClass = new PersonC("mike", 24);
        PersonC person2AsClass = new PersonC("mike", 24);

        Console.WriteLine(Person1AsARecord.ToString());
        Console.WriteLine(personAsClass.ToString());

        Console.WriteLine("are equal? "+ Equals(Person1AsARecord, Person2AsARecord));
        Console.WriteLine("are equal? "+ Equals(personAsClass, person2AsClass));
        
        // records compare values while classes compare references

        Console.WriteLine("are references equal? "+ ReferenceEquals(Person1AsARecord, Person2AsARecord));
        Console.WriteLine("are references equal? "+ ReferenceEquals(personAsClass, person2AsClass));
        //yes both references are not equal

        Console.WriteLine("are equal in values" + person2AsClass.GetHashCode());
        Console.WriteLine("are equal in values" + personAsClass.GetHashCode());

        var (name, age) = Person1AsARecord;
        Console.WriteLine(name);
        Console.WriteLine(age);
        
        Console.WriteLine(Person1AsARecord.name);
        Console.WriteLine(Person1AsARecord.age);
        Console.WriteLine(Person1AsARecord.ToString());


    }
}