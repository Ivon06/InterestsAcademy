using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Request
{
    public class AllRequestViewModel
    {
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string TeacherName { get; set; }
        public string CourseDuration { get; set; }
        public bool IsApproved { get; set; }
        public string RoomId { get; set; }
        public string CourseId { get; set; }

        public List<RequestViewModel> Requests { get; set; } = new List<RequestViewModel>();
    }
}
