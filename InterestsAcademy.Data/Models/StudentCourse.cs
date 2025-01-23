using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
    public class StudentCourse
    {
        [Required]
        [ForeignKey(nameof(Course))]
        public string CourseId { get; set; } = null!;

        [Required]
        public Course Course { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; } = null!;

        [Required]
        public Student Student { get; set; } = null!;

        public bool IsApproved { get; set; } = false;
    }
}
