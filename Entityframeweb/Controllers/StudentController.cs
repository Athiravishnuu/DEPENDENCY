using Entityframeweb.Db;
using Entityframeweb.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entityframeweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DemoDbContext _dbContext;    
        public StudentController(DemoDbContext dbContext)
        {   
                _dbContext = dbContext;         
        }
        public void Addstudent(Student student)
        {
            Student s1 = new Student();
            s1.Name = "ATHIRA";
            s1.Phonenumber = "45667";

            Student s2 = new Student();
            s2.Name = "Vishnu";
            s2.Phonenumber = "778787878";

         
            _dbContext.Students.Add(s1);
            _dbContext.Students.Add(s2);
            _dbContext.SaveChanges();

           List<Student> studentList = _dbContext.Students.Include(i => i.Address).ToList();






        }
    }
}
