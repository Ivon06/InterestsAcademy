using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Activity
{
    public class ActivityViewModel
    {
        public string Id { get; set; } = null!;
        public string Topic { get; set; } = null!;
        public string CourseId { get; set; } = null!;
        public string Day { get; set; } = null!;
        public string CourseName { get; set; } = null!;
        public int Date { get;set; }
        public string? StartHour { get; set; }
        public string? EndHour { get; set; }
        public string RoomId { get; set; } = null!;
            

    }
}
