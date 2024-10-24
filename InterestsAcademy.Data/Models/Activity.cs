using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
	public class Activity
	{
		[Key]
		public string Id { get; set; }

		[Required]
		[ForeignKey(nameof(Course))]
		public string CourseId { get; set; } = null!;

		[Required]
		public Course Course { get; set; } = null!;

		[Required]
		public DateTime Date { get; set; }

		[Required]
		[ForeignKey(nameof(Room))]
		public string RoomId { get; set; } = null!;

		[Required]
		public Room Room { get; set; } = null!;

		[Required]
		public TimeSpan Duration { get; set; }

		public ICollection<ActivityStudent> ActivityStudents { get; set; } = new HashSet<ActivityStudent>();

	}
}
