using InterestsAcademy.Core.Contracts;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Hubs
{
    public class RequestHub : Hub
    {
        private readonly IRequestService requestService;

        public RequestHub(IRequestService requestService)
        {
            this.requestService = requestService;
        }

        public async Task SendRequest(string requestId, string teacherUserId, string studentName, string studentEmail)
        {
            var request = await requestService.GetRequestByIdAsync(requestId);

            await Clients.User(teacherUserId).SendAsync("ReceiveRequest", studentEmail,studentName, request.Status, request.Id, request.TeacherId, request.CourseId );

        }

        //public async Task SendRequest(string topic, string message, string requestId, string companyUserId)
        //{
        //    var request = await requestService.GetRequestByIdAsync(requestId);

        //    await Clients.User(companyUserId).SendAsync("ReceiveRequest", topic, message, request.Status, request.DateCreated, request.Id, request.TeacherId, request.TeacherName);
        //}
    }
}
