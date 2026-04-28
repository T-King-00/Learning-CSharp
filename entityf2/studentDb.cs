using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace entityf2;

public class StudentDb : DbContext
{
    public string DbPath { get; } = Path.Combine("C:\\Users\\tony_\\source\\repos\\T-King-00\\Learning-CSharp\\entityf2","Student.db");
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>();
        //seeding a table
        modelBuilder.Entity<Student>().HasData(new { id = 1, name = "Tony", age = 20});
        modelBuilder.Entity<Course>().HasData(new { id=1, Name="C#"} );

        modelBuilder.Entity("CourseStudent").HasData(new { Coursesid = 1, Studentsid = 1 })
            ;

    }

    public void GetStudents()
    {
        foreach (var item in this.Students.Include(x => x.Courses).ToList())
        {
            Console.WriteLine(">" + item.name + ", age " + item.age + "");
            
            foreach (var course in item.Courses)
            {
                Console.WriteLine("\t >Course Name: " + course.Name + ",id: " + course.id + "");
            }
           
           
        }
        

    }
}

