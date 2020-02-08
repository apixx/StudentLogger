using StudentLoggerApp.Models;
using StudentLoggerApp.Repositories.Interfaces;
using StudentLoggerApp.Services.Interfaces;
using System.Collections.Generic;

namespace StudentLoggerApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public bool DeleteStudent(int id)
        {
            return studentRepository.DeleteStudent(id);
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return studentRepository.GetAllStudents();
        }

        public Student GetStudent(int id)
        {
            return studentRepository.GetStudent(id);
        }

        public Student NewStudent(Student student)
        {
            return studentRepository.NewStudent(student);
        }

        public Student UpdateStudent(Student student)
        {
            return studentRepository.UpdateStudent(student);
        }
    }
}
