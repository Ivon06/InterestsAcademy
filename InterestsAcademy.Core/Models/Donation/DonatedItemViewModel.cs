using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Donation
{
    public class DonatedItemViewModel
    {
        public string Id { get; set; }
        //public string ItemName { get; set; }
        public int Quantity { get; set; }
        //public string Category { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
    }
}
