using Freddie.API.Models;

namespace Freddie.API.Services;

public class StudentService : IStudentService
{
    public IQueryable<Student> RetrieveAllStudents()
    {
        return new List<Student>
        {
            new()
            {
                Id = new Guid("caa126e8-2cd2-4cc2-8a43-7936eaed097f"),
                Name = "Vishu Goli",
                Score = 200
            },
            new()
            {
                Id = new Guid("a5b1a7b2-2b2f-456c-b346-8790cbe87cba"),
                Name = "Kailu Hu",
                Score = 160
            },
            new()
            {
                Id = new Guid("75cfe4fc-3a19-4b3b-b131-e0c697d679c8"),
                Name = "Sean Hobbs",
                Score = 170
            }
        }.AsQueryable();
    }
}