using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Data.Constants.CourseConstants;
using static InterestsAcademy.Common.ErrorMessages;

namespace InterestsAcademy.Data.Models
{
	public class Course
	{
        public Course()
        {
            Id = Guid.NewGuid().ToString();
            StudentCourses = new HashSet<StudentCourse>();
        }

        [Key]
		public string Id { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [ForeignKey(nameof(Teacher))]
        public string TeacherId { get; set; } = null!;

        public Teacher Teacher { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        public string RoomId { get; set; } = null!;

        public Room Room { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(CourseDescriptionMaxLength)]
        public string Description { get; set; } = null!;
        
        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<Activity> Activities { get; set; }

    }
}
