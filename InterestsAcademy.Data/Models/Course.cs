using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Common.ErrorMessages;
using static InterestsAcademy.Data.Constants.CourseConstants;

namespace InterestsAcademy.Data.Models
{
    public class Course
    {
        public Course()
        {
            Id = Guid.NewGuid().ToString();
            StudentCourses = new HashSet<StudentCourse>();
            Activities = new HashSet<Activity>();
            IsApproved = false;
        }

        [Key]
        public string Id { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [ForeignKey(nameof(Teacher))]
        public string TeacherId { get; set; } = null!;

        public Teacher Teacher { get; set; } = null!;

        // [Required(ErrorMessage = RequiredErrorMessage)]
        public DateTime StartDate { get; set; }

        // [Required(ErrorMessage = RequiredErrorMessage)]
        public DateTime EndDate { get; set; }

        //[Required(ErrorMessage = RequiredErrorMessage)]
        [ForeignKey(nameof(Room))]
        public string RoomId { get; set; }

        public Room Room { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
        [MaxLength(CourseDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public bool IsApproved { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
        public ICollection<Activity> Activities { get; set; }

        public ICollection<Request> Requests { get; set; } = new HashSet<Request>();

    }
}
