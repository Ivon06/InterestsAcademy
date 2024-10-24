using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
	public class RoomGiver
	{
		public RoomGiver()
		{
			Id = Guid.NewGuid().ToString();

		}

		[Key]
		public string Id { get; set; }

		[Required]
		[ForeignKey(nameof(Giver))]
		public string GiverId { get; set; }

		[Required]
		public Giver Giver { get; set; }

		[Required]
		[ForeignKey(nameof(Room))]
		public string RoomId { get; set; }

		[Required]
		public Room Room { get; set; }
	}
}
