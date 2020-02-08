using StudentLoggerApp.Models;
using System.Collections.Generic;

namespace StudentLoggerApp.Repositories.Interfaces
{
    public interface IActivityRepository
    {
        IEnumerable<Activity> GetAllByType(int type);
        IEnumerable<Activity> GetByStudent(int id);
        IEnumerable<Activity> GetByCourse(int id);
        bool NewActivity(Activity activity);
        bool UpdateActivity(Activity activity);
        bool DeleteActivity(int id);
    }
}
