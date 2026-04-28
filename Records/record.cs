using LearnCSharp.IComparable;

namespace LearnCSharp.Records;

public record Person(string name, int age)
{
    public string firstname { get;  set; } = name;
    public string fullname => name+" "+age;
};

public class PersonC
{
    public PersonC(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public string name { get; set; }
    public int age { get; set; }
}

