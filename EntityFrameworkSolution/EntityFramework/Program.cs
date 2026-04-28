// See https://aka.ms/new-console-template for more information

using EntityFramework;
using EntityFramework.db;


// var db=new PersonContext();
// Console.WriteLine("Database path: " + db.DbPath);
// Console.WriteLine("Database Created: " + db.Database.EnsureCreated());

// To force recreation (e.g. if schema changed):
/*
using (var db = new PersonContext())
{
    // db.Database.EnsureDeleted(); // Uncomment this to start fresh
    if (db.Database.EnsureCreated())
    {
        Console.WriteLine("Database was created.");
    }
    else
    {
        Console.WriteLine("Database already exists (EnsureCreated returned false).");
    }

    PersonService PService = new PersonService();
    PService.AddPerson(new Person("tony", 25, DateTime.Now)); 
}
*/



public class EntityF
{
    public static void Main0100(string[] args)
    {

        using var db = new PersonContext();
        
        Console.WriteLine("Database path:" + db.DbPath);
        Console.WriteLine(db.Database.EnsureCreated());
        db.Add(new Person("mike", 24, DateTime.Now));
        db.SaveChangesAsync();
        
    }
}

