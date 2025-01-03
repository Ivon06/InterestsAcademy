using InterestsAcademy.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Models
{
    public class Request
    {
        public Request()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; set; } = null!;

        [ForeignKey(nameof(Teacher))]
        public string TeacherId { get; set; } = null!;
        public Teacher Teacher { get; set; } = null!;

        [ForeignKey(nameof(Course))]
        public string CourseId { get; set; } = null!;
        public Course Course { get; set; } = null!;

        [ForeignKey(nameof(Student))]
        public string StudentId { get; set; } = null!;

        public Student Student { get; set; } = null!;

        [EnumDataType(typeof(RequestStatusEnum))]
        public string Status { get; set; } = null!;



    }
}
