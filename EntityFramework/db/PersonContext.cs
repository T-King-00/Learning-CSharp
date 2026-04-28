using Microsoft;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace EntityFramework.db;

public class PersonContext:DbContext
{    
    public DbSet<Person> Person { get; set; }
    public string DbPath { get; }

    public PersonContext()
    {
        var folder=Environment.SpecialFolder.LocalApplicationData;
        var path=Environment.GetFolderPath(folder);
        DbPath=Path.Combine(path,"person.db");
        
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    
}

public class Person
{
    public string  name { get; set; }
    public Guid id { get; set; }
    public int age { get; set; }
    public DateTime Birthdate { get; set; }
    
    public Person(string name,int age,DateTime birthdate)
    {
        this.name = name;
        this.age = age;
        this.Birthdate = birthdate;
    }
    public Person()
    {
        
    }
}