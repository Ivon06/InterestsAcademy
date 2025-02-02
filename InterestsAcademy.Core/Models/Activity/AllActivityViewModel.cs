using InterestsAcademy.Core.Models.Course;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Activity
{
    public class AllActivityViewModel
    {

        public ICollection<ActivityViewModel> DayNow { get; set; } = new HashSet<ActivityViewModel>();
        public ICollection<ActivityViewModel> DayTomorrow { get; set; } = new HashSet<ActivityViewModel>();
        public ICollection<ActivityViewModel> Day2 { get; set; } = new HashSet<ActivityViewModel>();
        public ICollection<ActivityViewModel> Day3 { get; set; } = new HashSet<ActivityViewModel>();
        public ICollection<ActivityViewModel> Day4 { get; set; } = new HashSet<ActivityViewModel>();
        public ICollection<ActivityViewModel> Day5 { get; set; } = new HashSet<ActivityViewModel>();
        public ICollection<ActivityViewModel> Day6 { get; set; } = new HashSet<ActivityViewModel>();

        public bool TeacherView { get; set; }
        public bool RoomView { get; set; }
        public bool CourseView { get; set; }

        public string? CourseId { get; set; }

        public string? RoomId { get; set; }
        public string? TeacherId { get; set; }

        public int Days { get; set; } = 0;

        public string Month { get; set; } = null!;

        public ICollection<CourseCardViewModel> AllRoomCourses { get; set; } = new HashSet<CourseCardViewModel>();

    }

}
