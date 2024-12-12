using InterestsAcademy.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Data.Constants.UserConstants;
using static InterestsAcademy.Common.ErrorMessages;

namespace InterestsAcademy.Core.Models.Account
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(UserNameMaxLength, MinimumLength = UserNameMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [StringLength(UserNameMaxLength, MinimumLength = UserNameMinLength, ErrorMessage = InvalidLengthMessage)]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [EmailAddress]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [DataType(DataType.Password)]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength, ErrorMessage = InvalidLengthMessage)]

        public string Password { get; set; } = null!;

        [Required(ErrorMessage = RequiredErrorMessage)]
        [Compare(nameof(Password), ErrorMessage = DifferentPasswordMessage)]
        [DataType(DataType.Password)]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength, ErrorMessage = InvalidLengthMessage)]
        public string PasswordRepeat { get; set; } = null!;

       

        public IFormFile? ProfilePicture { get; set; }


    }
}
