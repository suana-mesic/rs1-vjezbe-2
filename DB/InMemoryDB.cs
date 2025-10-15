using WebApplication1.Models;

namespace WebApplication1.DB
{
    public static class InMemoryDB
    {
        public static List<Student> Studenti = new List<Student>()
        {
            new Student()
            {
                Id=1,
                Ime="Student1",
                Prezime="Prezime1",
                DateCreated =DateTime.Now
            }
        };

    }
}
