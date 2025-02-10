using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Email
{
    public class SendMessageQueryModel
    {
        [Required]
        public string From { get; set; } = null!;
        [Required]
        public string Subject { get; set; } = null!;
        [Required]
        public string Content { get; set; } = null!;
        [Required]
        public string Name { get; set; } = null!;
    }
}
