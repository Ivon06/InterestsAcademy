using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Common.ErrorMessages;

namespace InterestsAcademy.Data.Models
{
	public class Activity
	{

        public Activity()
        {
            Id = Guid.NewGuid().ToString();
			IsActive = true;
        }
        [Key]
		public string Id { get; set; }

		[Required(ErrorMessage = RequiredErrorMessage)]
		[ForeignKey(nameof(Course))]
		public string CourseId { get; set; } = null!;

		[Required(ErrorMessage = RequiredErrorMessage)]

		public string Topic { get; set; } = null!;

		[Required(ErrorMessage = RequiredErrorMessage)]
		public Course Course { get; set; } = null!;

		[Required(ErrorMessage = RequiredErrorMessage)]
		public DateTime Start { get; set; }

		//[Required(ErrorMessage = RequiredErrorMessage)]
		//[ForeignKey(nameof(Room))]
		//public string RoomId { get; set; } = null!;

		//[Required(ErrorMessage = RequiredErrorMessage)]
		//public Room Room { get; set; } = null!;

		[Required(ErrorMessage = RequiredErrorMessage)]
		public DateTime End { get; set; }

		public bool IsActive { get; set; }
		public ICollection<ActivityStudent> ActivityStudents { get; set; } = new HashSet<ActivityStudent>();

	}
}
