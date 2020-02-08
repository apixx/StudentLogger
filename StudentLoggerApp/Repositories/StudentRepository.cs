using StudentLoggerApp.Models;
using StudentLoggerApp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StudentLoggerApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentLoggerContext context;

        public StudentRepository(StudentLoggerContext studentLoggerContext)
        {
            context = studentLoggerContext;
        }
        public bool DeleteStudent(int id)
        {
            var student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                return SaveDB();
            }
            return false;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return context.Students.ToList();
        }

        public Student GetStudent(int id)
        {
            return context.Students.Find(id);
        }

        public Student NewStudent(Student student)
        {
            context.Students.Add(student);
            SaveDB();
            return student;
        }

        public Student UpdateStudent(Student student)
        {
            context.Students.Update(student);
            SaveDB();
            return student;
        }

        private bool SaveDB()
        {
            return context.SaveChanges() > 0;
        }
    }
}
