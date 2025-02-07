using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Common.ErrorMessages;
using static InterestsAcademy.Data.Constants.UserConstants;

namespace InterestsAcademy.Core.Models.Profile
{
    public class EditProfileViewModel
    {
        public string Id { get; set; }
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

        
        public string PhoneNumber { get; set; } 

        [StringLength(CountryMaxLength, MinimumLength = CountryMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Country { get; set; } 

        
        [StringLength(CityMaxLength, MinimumLength = CityMinLength, ErrorMessage = InvalidLengthMessage)]
        public string City { get; set; } 

        
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength, ErrorMessage = InvalidLengthMessage)]
        public string Address { get; set; } 


        public IFormFile? ProfilePicture { get; set; }
    }
}
