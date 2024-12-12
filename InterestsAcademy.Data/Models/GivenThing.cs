using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Data.Constants.GivenThingConstant;

namespace InterestsAcademy.Data.Models
{
	public class GivenThing
	{
        public GivenThing()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
		public string Id { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Giver))]
        public string GiverId { get; set; }

        [Required]
        public Giver Giver { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(MaterialBaseItem))]
        public string MaterialItemId { get; set; } = null!;

        [Required]
        public MaterialBaseItem MaterialBaseItem { get; set; } = null!;

	}
}
