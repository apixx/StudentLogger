using StudentLoggerApp.Models;
using System.Collections.Generic;

namespace StudentLoggerApp.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int id);
        Student NewStudent(Student student);
        Student UpdateStudent(Student student);
        bool DeleteStudent(int id);
    }
}
