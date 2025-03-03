using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Activity
{
    public class DetailsViewModel
    {
        public DetailsViewModel()
        {
            
        }
        public string Id { get; set; } = null!;

        public string Description { get; set; } = null!;

        
        public string Coures { get; set; } = null!;

        public TeacherDetailsViewModel Teacher { get; set; } = null!;

        
    }
}
