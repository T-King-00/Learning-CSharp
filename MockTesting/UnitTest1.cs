using EntityFramework;
using EntityFramework.db;
using Moq;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace MockTesting;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var person = new Person("mike", 24, DateTime.Now);
        
        var mock = new Mock<IPersonRepo>();
        mock.Setup(x => x.AddPerson(It.IsAny<Person>())).Returns(true);
        
        var service = new PersonService(mock.Object);

        service.AddPerson(person);
        service.AddPerson(person);
        
        mock.Verify(x => x.AddPerson(It.Is<Person>(p => p.name == "mike" && p.age == 24)), Times.Exactly(2));
    }
    
    [Fact]
    public void ListALL_shouldreturn_all_records()
    {
        var fakelist = new List<Person>()
        {
            new Person("hoda", 24, DateTime.Now), 
            new Person("tony", 24, DateTime.Now),
            new Person("john", 24, DateTime.Now),
            new Person("ahmed", 24, DateTime.Now)

        };
        var mock = new Mock<IPersonRepo>();
        mock.Setup(x=>x.ListAll()).Returns(fakelist);
        
        
        
        
        var service = new PersonService(mock.Object);

        foreach (var item in service.ListAll())
        {
            Console.WriteLine(">" + item.name + ", age " + item.age ) ;
            
        }


        Assert.Equal(fakelist, service.ListAll());
        Assert.Equal(fakelist.Count, service.ListAll().Count);
        
        
        mock.Verify(x=>x.ListAll(), Times.Exactly(3));
    }
}