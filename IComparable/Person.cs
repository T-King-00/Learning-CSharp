namespace LearnCSharp.IComparable;


public class Person : System.IComparable

{
    public int age { get; set; }
    public string name { get; set; }


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