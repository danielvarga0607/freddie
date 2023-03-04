using Freddie.API.Models;

namespace Freddie.API.Services;

public interface IStudentService
{
    IQueryable<Student> RetrieveAllStudents();
}
