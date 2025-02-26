using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Course
{
    public class TeacherProfileCourseViewModel
    {
        public TeacherProfileCourseViewModel()
        {
            Cards = new List<CourseCardViewModel>();
        }

        public string TeacherId { get; set; }
        public string TeacherName { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string? ProfilePictureUrl { get; set; }

        // Courses
        public IEnumerable<CourseCardViewModel> Cards { get; set; }
    }


}
