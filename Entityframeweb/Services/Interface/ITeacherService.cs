using Entityframeweb.Model;

namespace Entityframeweb.Services.Interface
{
    public interface ITeacherService
    {
        public void AddTeacher( Teacher teacher);
        public List<Teacher> GetTeachers();
    }
}
