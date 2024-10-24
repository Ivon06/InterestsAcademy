using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
	public class CourseGiver
	{
        public CourseGiver()
        {
            Id = Guid.NewGuid().ToString();

        }

        [Key]
        public string Id { get; set; }

        [Required]  
        [ForeignKey(nameof(Giver))]
        public string GiverId { get; set; }

        [Required]
        public Giver Giver { get; set; }

        [Required]
        [ForeignKey(nameof(Course))]
        public string CourseId { get; set; }

        [Required]
        public Course Course { get; set; }
	}
}
