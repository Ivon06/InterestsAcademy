using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Activity
{
    public class ActivityQueryModel
    {
        public string Topic { get; set; } = null!;

        
        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string? CourseId { get; set; }

        public string TeacherId { get; set; } = null!;

        

    }
}
