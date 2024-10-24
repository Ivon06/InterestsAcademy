using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
	public class ActivityStudent
	{
		[Required]
		[ForeignKey(nameof(Activity))]
		public string ActivityId { get; set; } = null!;

		[Required]
		public Activity Activity { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(Student))]
		public string StudentId { get; set; } = null!;

		[Required]
		public Student Student { get; set; } = null!;
	}
}
