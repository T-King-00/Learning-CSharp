namespace LearnCSharp.DeepCopy_vs_ShallowCopy;


public class Person : System.IComparable 

{
    public int age { get; set; }
    public string name { get; set; }
    //this constructor is used for deeep copying purposes only.
    public Person(Person person)
    {
        this.age = person.age;
        this.name = person.name;
    }
    public Person()
    {
     
    }
    public int CompareTo(object obj)
    {
        if (obj is null)
        {
            return -9999;
        }

        int res=99999;
        if (obj is Person person)
        {
             res = this.age.CompareTo(person.age);
        }

        return res;
    }
}