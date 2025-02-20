using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Donation
{
    public class AllDonationsForAdminViewModel
    {
        public string Id { get; set; }

      
        public string ItemName { get; set; }
        public int NeededQuantity { get; set; }

        public string Category { get; set; }

        public List<DonatedItemViewModel> DonatedItems { get; set; } = new List<DonatedItemViewModel>();


    }
}
