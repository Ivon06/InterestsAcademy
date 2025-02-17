using InterestsAcademy.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
    public class MaterialBaseItem
    {
        public MaterialBaseItem()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int NeededQuantity { get;set; }

        [Required]
        [EnumDataType(typeof(DonationCategoryEnum))]
        public string Category { get; set; } = null!;

        

        public ICollection<GivenThing> GivenThings { get; set; }
    }
}
