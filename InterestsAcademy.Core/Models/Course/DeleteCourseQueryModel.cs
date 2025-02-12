using InterestsAcademy.Core.Models.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Common.ErrorMessages;
using static InterestsAcademy.Data.Constants.CourseConstants;

namespace InterestsAcademy.Core.Models.Course
{
    public class DeleteCourseQueryModel
    {
        [Required]
        public string Id { get; set; } = null!;
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(CourseNameMaxLength, MinimumLength = CourseNameMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(CourseDescriptionMaxLength, MinimumLength = CourseDescriptionMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Description { get; set; } = null!;


        [Required(ErrorMessage = RequiredErrorMessage)]
        public string Duration { get; set; } = null!;

    }
}
