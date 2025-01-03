using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
	public class Teacher
	{
		public Teacher()
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

		public ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        public ICollection<Request> Requests { get; set; } = new HashSet<Request>();

    }
}
