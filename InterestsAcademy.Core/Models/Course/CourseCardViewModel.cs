using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Course
{
    public class CourseCardViewModel
    {
        public string Id { get;set; }
        public string Name { get;set; }
        public string Description { get; set; }
        public string TeacherId { get;set; }
        public bool IsApproved { get;set;}
    }
}
