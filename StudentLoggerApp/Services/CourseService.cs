using StudentLoggerApp.Models;
using StudentLoggerApp.Repositories.Interfaces;
using StudentLoggerApp.Services.Interfaces;
using System.Collections.Generic;

namespace StudentLoggerApp.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public bool DeleteCourse(int id)
        {
            return courseRepository.DeleteCourse(id);
        }

        public bool EnrollStudent(int studentId, int courseId)
        {
            return courseRepository.EnrollStudent(studentId, courseId);
        }

        public bool EnrollStudents(int[] studentIds, int courseId)
        {
            return courseRepository.EnrollStudents(studentIds, courseId);
        }

        public Course Get(int id)
        {
            return courseRepository.Get(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return courseRepository.GetAll();
        }

        public Course NewCourse(Course course)
        {
            return courseRepository.NewCourse(course);
        }

        public Course UpdateCourse(Course course)
        {
            return courseRepository.UpdateCourse(course);
        }
    }
}
