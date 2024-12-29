using InterestsAcademy.Core.Models.Room;
using InterestsAcademy.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Common.ErrorMessages;

using static InterestsAcademy.Data.Constants.CourseConstants;

namespace InterestsAcademy.Core.Models.Course
{
    public class CourseQueryModel
    {

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(CourseNameMaxLength, MinimumLength =CourseNameMinLength, ErrorMessage=InvalidLengthMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(CourseDescriptionMaxLength, MinimumLength = CourseDescriptionMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Description { get; set; } = null!;

       // [Required(ErrorMessage = RequiredErrorMessage)]
        public string? TeacherId { get;set; } 
        [Required(ErrorMessage = RequiredErrorMessage)]
        public string RoomId { get; set; } = null!;

        public ICollection<RoomViewModel> Rooms { get; set; } = new List<RoomViewModel>();




    }
}
