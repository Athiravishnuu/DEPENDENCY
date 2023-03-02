using Entityframeweb.Db;
using Entityframeweb.Model;
using Entityframeweb.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Entityframeweb.Services;

public class StudentServices : IStudentService
{
    private readonly DemoDbContext _dbContext;
    public StudentServices(DemoDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void AddStudent(Student Student)
    {
        _dbContext.Students.Add(Student); 
    }

    public List<Student> GetAllStudents()
    {
        return _dbContext.Students.ToList() ;
    }
}
