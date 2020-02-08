using StudentLoggerApp.Models;
using StudentLoggerApp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StudentLoggerApp.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private readonly StudentLoggerContext context;

        public ActivityRepository(StudentLoggerContext studentLoggerContext)
        {
            context = studentLoggerContext;
        }

        public bool DeleteActivity(int id)
        {
            var activity = context.Activities.Find(id);
            if (activity != null)
            {
                context.Activities.Remove(activity);
                return SaveDB();
            }
            return false;
        }

        public IEnumerable<Activity> GetAllByType(int type)
        {
            return context.Activities.Where(activity => activity.ActivityType == type).ToList();
        }

        public IEnumerable<Activity> GetByCourse(int id)
        {
            return context.Activities.Where(activity => activity.CourseId == id).ToList();

        }

        public IEnumerable<Activity> GetByStudent(int id)
        {
            return context.Activities.Where(activity => activity.StudentId == id).ToList();
        }

        public bool NewActivity(Activity activity)
        {
            context.Activities.Add(activity);
            return SaveDB();
        }

        public bool UpdateActivity(Activity activity)
        {
            context.Activities.Update(activity);
            return SaveDB();
        }

        private bool SaveDB()
        {
            return context.SaveChanges() > 0;
        }
    }
}
