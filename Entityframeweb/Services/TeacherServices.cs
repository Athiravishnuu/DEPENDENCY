using Entityframeweb.Db;
using Entityframeweb.Model;
using Entityframeweb.Services.Interface;

namespace Entityframeweb.Services
{
    public class TeacherServices : ITeacherService
    { 
     private readonly DemoDbContext _dbContext;
        public TeacherServices(DemoDbContext dbContext)
        { 
            _dbContext = dbContext;
        }
        public void AddTeacher(Teacher teacher)
        {
            _dbContext.Teachers.Add(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            return _dbContext.Teachers.ToList();
        }
    }
}
