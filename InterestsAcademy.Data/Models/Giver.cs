using InterestsAcademy.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
	public class Giver
	{
		public Giver()
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

		[Required]
        [EnumDataType(typeof(GiverType))]
        public string GiverType { get; set; }

		public ICollection<GivenThing> GivenThings { get; set; } = new HashSet<GivenThing>();
		//public ICollection<RoomGiver> RoomGivers { get; set; } = new HashSet<RoomGiver>();

		//public ICollection<CourseGiver> CourseGivers { get; set; } = new HashSet<CourseGiver>();

	}
}
