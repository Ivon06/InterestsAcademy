using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Donation
{
    public class CreateDonationViewModel
    {
        public string Id { get; set; }

        
        public string ItemName { get; set; }
        public int NeededQuantity { get; set; }

        public int Quantity { get; set; }
        public string Category { get; set; }
    }
}
