using System.Runtime.CompilerServices;

namespace LearnCSharp.ExtensionMethods;

public static class PersonExtension
{
    // public static string GetFullName(this Person person)
    // {
    //     person.Name = person.Name.ToUpper();
    //      return person.Name;
    // }

    extension(Person person)
    {
        public string GetFullName() =>   person.Name.ToUpper();
        
    }

    extension
        (string name)
    {
        public string writeTony() => "tony";
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}