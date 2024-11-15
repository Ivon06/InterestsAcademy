using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
	public class Room
	{
		public Room()
		{
			Id = Guid.NewGuid().ToString();
		}

		[Key]
		public string Id { get; set; } = null!;

		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = null!;

		[Required]
		public int Floor {  get; set; }

		[Required]
		public int Capacity {  get; set; }

		public ICollection<Activity> Activities{ get; set; } = new HashSet<Activity>();
		public ICollection<RoomGiver> RoomGivers { get; set; } = new HashSet<RoomGiver>();
	}
}
