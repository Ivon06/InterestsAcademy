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
        public string Name { get; set; }

        [Required]
        public int NeededQuantity { get;set; }

        public ICollection<GivenThing> GivenThings { get; set; }
    }
}
