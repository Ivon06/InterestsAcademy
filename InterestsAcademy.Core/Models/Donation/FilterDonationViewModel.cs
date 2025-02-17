using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Donation
{
    public class FilterDonationViewModel
    {
        public FilterDonationViewModel()
        {
            Donations = new List<DonationViewModel>();
        }
        public ICollection<DonationViewModel> Donations { get; set; }
        public string Categoty { get; set; }
    }
}
