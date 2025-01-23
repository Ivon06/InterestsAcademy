using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class ActivityService : IActivityService
    {
        public Task<List<Activity>> GetAllActivitiesByRoomId(int roomId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Activity>> GetAllActivityByCourseId(int courseId)
        {
            throw new NotImplementedException();
        }
    }
}
