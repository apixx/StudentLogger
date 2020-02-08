using StudentLoggerApp.Models;
using System.Collections.Generic;

namespace StudentLoggerApp.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
        Course Get(int id);
        Course NewCourse(Course course);
        Course UpdateCourse(Course course);
        bool DeleteCourse(int id);
        bool EnrollStudent(int studentId, int courseId);
        bool EnrollStudents(int[] studentIds, int courseId);
    }
}
