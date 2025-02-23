using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Course
{
    public class MyCoursesViewModel
    {
        public MyCoursesViewModel()
        {
            Cards = new List<CourseCardViewModel>();
            Categories = new List<string>();
        }
        public IEnumerable<CourseCardViewModel> Cards { get; set; }
        public List<string> Categories { get; set; }

        public string? SearchString { get; set; }
        public string? Category { get; set; }
        public Dictionary<string, string> Photos { get; set; }

    }
}
