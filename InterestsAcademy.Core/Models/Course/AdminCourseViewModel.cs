using InterestsAcademy.Core.Models.Request;
using InterestsAcademy.Core.Models.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Course
{
    public class AdminCourseViewModel
    {
        public string Id { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string TeacherName { get; set; }
        public string CourseDuration { get; set; }
        public bool IsApproved { get; set; }
        public string? RoomName { get;set; }
        public string RoomId { get; set; }
        public List<RoomViewModel> Rooms { get; set; } = new List<RoomViewModel>();

        public List<RequestViewModel> Requests { get; set; } = new List<RequestViewModel>();
    }
}
