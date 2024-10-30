using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Data.Constants.UserConstants;
using static InterestsAcademy.Common.ErrorMessages;
namespace InterestsAcademy.Core.Models.Account
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(PasswordMaxLength, MinimumLength = PasswordMinLength, ErrorMessage = InvalidLengthMessage)]

        public string Password { get; set; } = null!;
    }
}
