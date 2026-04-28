using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace entityf2;

public class Course
{
    [Key]
    public int id { get; set; }
    
    public string Name { get; set; }
    
    public List<Student> Students{ get; set;}

}
public class Student
{   
    public string name { get; set; }
    public int age { get; set; }
    [Key]
    public int id { get; set; }
    
    public List<Course> Courses{ get; set;}
}