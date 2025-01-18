using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IActivityService
    {
        Task<List<Activity>> GetAllActivitiesByRoomId(int roomId);
        Task<List<Activity>> GetAllActivityByCourseId(int courseId);
    }
}
