using StudentManagement.Models;

namespace StudentManagement.Services
{
    public interface IStudentServices
    {
        public List<Student> GetStudentsList();
        public string InsertStudent(Student student);
        public string UpdateStudent(Student student);
        public string DeleteStudent(int StudentId);

    }
}
