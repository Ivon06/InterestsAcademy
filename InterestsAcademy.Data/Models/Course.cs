using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Data.Constants.CourseConstants;

namespace InterestsAcademy.Data.Models
{
	public class Course
	{
        public Course()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
		public string Id { get; set; } = null!;

        [Required]
        [MaxLength(CourseNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [ForeignKey(nameof(Teacher))]
        public string TeacherId { get; set; } = null!;

        public Teacher Teacher { get; set; } = null!;
		public ICollection<CourseGiver> CourseGivers { get; set; } = new HashSet<CourseGiver>();

	}
}
