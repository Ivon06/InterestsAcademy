using InterestsAcademy.Core.Contracts;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Hubs
{
    public class ActivityHub : Hub
    {
        private readonly IActivityService activityService;

        public ActivityHub(IActivityService activityService) { 
            this.activityService = activityService;
        }

        public async Task SendMeeting(string activityId, List<string> studentIds)
        {
            var meetingData = await activityService.GetActivityByIdAsync(activityId);

            await Clients.Users(studentIds).SendAsync("ReceiveMeeting", meetingData, activityId);

        }

        public async Task DeleteMeeting(string meetingId, List<string> receiversIds)
        {
            await Clients.Users(receiversIds).SendAsync("ReceiveDelete", meetingId);
        }
    }
}
