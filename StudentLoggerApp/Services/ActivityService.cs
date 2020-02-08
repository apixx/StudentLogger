using StudentLoggerApp.Models;
using StudentLoggerApp.Repositories.Interfaces;
using StudentLoggerApp.Services.Interfaces;
using System.Collections.Generic;

namespace StudentLoggerApp.Services
{
    public class ActivityService : IActivityService
    {
        public ActivityService(IActivityRepository activityRepository) 
        {
            this.activityRepository = activityRepository;
        }

        private readonly IActivityRepository activityRepository;
        public bool DeleteActivity(int id)
        {
            return activityRepository.DeleteActivity(id);
        }

        public IEnumerable<Activity> GetAllByType(int type)
        {
            return activityRepository.GetAllByType(type);
        }

        public IEnumerable<Activity> GetByCourse(int id)
        {
            return activityRepository.GetByCourse(id);
        }

        public IEnumerable<Activity> GetByStudent(int id)
        {
            return activityRepository.GetByStudent(id);
        }

        public bool NewActivity(Activity activity)
        {
            return activityRepository.NewActivity(activity);
        }

        public bool UpdateActivity(Activity activity)
        {
            return activityRepository.UpdateActivity(activity);
        }
    }
}
