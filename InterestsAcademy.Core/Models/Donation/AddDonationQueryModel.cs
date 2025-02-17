using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Donation
{
    public class AddDonationQueryModel
    {
        public AddDonationQueryModel()
        {
            Categories = new List<string>();
        }

        [Required]
        public string ItemName { get; set; } = null!;
        public int Quantity { get; set; }
        public string Category { get; set; }

        public ICollection<string> Categories { get; set; }


    }
}
