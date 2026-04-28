using EntityFramework.db;

namespace EntityFramework;

public interface IPersonRepo
{
    public bool AddPerson(Person person);
    
    public List<Person> ListAll();
}

public class PersonService : IPersonRepo
{
    
    private readonly PersonContext? _context;
    private readonly IPersonRepo? _personRepo;
    public PersonService(IPersonRepo personRepo)
    {
        _personRepo = personRepo;
    }

    public PersonService()
    {
        _context = new PersonContext();
    }

    public bool AddPerson(Person person)
    {
        if (_personRepo != null)
        {
            return _personRepo.AddPerson(person);
        }

        if (_context != null)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return true;
        }

        return false;
    }

    public List<Person> ListAll()
    {
        if (_personRepo != null)
        {
            return _personRepo.ListAll();
        }

        if (_context != null && _context.Person != null)
        {
            return _context.Person.ToList();
        }

        return new List<Person>();
    }

   
}