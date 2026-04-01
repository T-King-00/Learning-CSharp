using System;
using System.Security.Cryptography;
using LearnCSharp.DeepCopy_vs_ShallowCopy;

namespace LearnCSharp.Records;




public class program
{
    public static void Main0001(string[] args)
    {

        Person PersonAsARecord = new Person("tony", 23);
        PersonAsARecord=PersonAsARecord with { age = 52 };
        
        Console.WriteLine(PersonAsARecord.name+"    "+PersonAsARecord.age);
        Console.WriteLine(PersonAsARecord.fullname);
        
        //
        // var person = new Person();
        // person.name = "tony";
        // var p2 = new Person();
        // p2.name = "tony";


    }
}