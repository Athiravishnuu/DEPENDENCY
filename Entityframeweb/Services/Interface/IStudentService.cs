using Entityframeweb.Model;

namespace Entityframeweb.Services.Interface
{
    public interface IStudentService
    {
        public void AddStudent(Student Student);
        public List<Student> GetAllStudents();
    }
}
