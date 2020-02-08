using StudentLoggerApp.Models;
using StudentLoggerApp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StudentLoggerApp.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly StudentLoggerContext context;

        public CourseRepository(StudentLoggerContext studentLoggerContext)
        {
            context = studentLoggerContext;
        }

        public bool DeleteCourse(int id)
        {
            var course = context.Courses.Find(id);
            if (course != null)
            {
                context.Courses.Remove(course);
                return SaveDB();
            }
            return false;
        }

        public bool EnrollStudent(int studentId, int courseId)
        {
            var enrolledIn = new EnrolledIn
            {
                StudentId = studentId,
                CourseId = courseId,
                StudentYear = ""
            };
            context.EnrolledIns.Add(enrolledIn);

            return SaveDB();
        }

        public bool EnrollStudents(int[] studentIds, int courseId)
        {
            foreach(var id in studentIds)
            {
                var enrolledIn = new EnrolledIn
                {
                    StudentId = id,
                    CourseId = courseId,
                    StudentYear = ""
                };
                context.EnrolledIns.Add(enrolledIn);
            }

            return SaveDB();
        }

        public Course Get(int id)
        {
            return context.Courses.Find(id);
        }

        public IEnumerable<Course> GetAll()
        {
            return context.Courses.ToList();
        }

        public Course NewCourse(Course course)
        {
            context.Courses.Add(course);
            SaveDB();
            return course;
        }

        public Course UpdateCourse(Course course)
        {
            context.Courses.Update(course);
            SaveDB();
            return course;
        }

        private bool SaveDB()
        {
            return context.SaveChanges() > 0;
        }
    }
}
