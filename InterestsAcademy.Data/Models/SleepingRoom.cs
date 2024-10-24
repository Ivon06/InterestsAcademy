using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Data.Constants.SleepingRoomConstants;

namespace InterestsAcademy.Data.Models
{
	public class SleepingRoom
	{
		public SleepingRoom()
		{
			Id = Guid.NewGuid().ToString();
		}

		[Key]
		public string Id { get; set; } = null!;

		[Required]
		public int CountOfBed {  get; set; }

		[Required]
		public int Number { get; set; }

		[Required]
		[MaxLength(DescriptionMaxLength)]
		public string Description { get; set; } = null!;

		public ICollection<Student> Students { get; set; } = new HashSet<Student>();

	}
}
