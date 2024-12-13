using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
	public class Student
	{
		public Student()
		{
			Id = Guid.NewGuid().ToString();
		}

		[Key]
		public string Id { get; set; } = null!;

		[Required]
		[ForeignKey(nameof(User))]
		public string UserId { get; set; } = null!;
		[Required]
		public User User { get; set; }

		[ForeignKey(nameof(SleepingRoom))]
		public string? SleepingRoomId { get;set; }

		public SleepingRoom SleepingRoom { get; set; }

		public ICollection<ActivityStudent> ActivitiesStudents { get; set; } = new HashSet<ActivityStudent>();
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();

    }
}
