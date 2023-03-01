namespace Entityframeweb.Model
{
    public class Student
    {  
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public virtual Address Address { get; set; }
    }
}
