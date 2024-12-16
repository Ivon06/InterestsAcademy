using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InterestsAcademy.Data.Constants.UserConstants;
using System.Reflection;
using InterestsAcademy.Data.Models.Enums;
using Microsoft.AspNetCore.Identity;

namespace InterestsAcademy.Data.Models
{
	public class User : IdentityUser
	{
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
		public string Id { get; set; } = null!;

		[Required]
		[MaxLength(UserNameMaxLength)]
		public string Name { get; set; }

		public DateTime BirthDate { get; set; }

		public DateTime RegisteredOn { get; set; }

		[EnumDataType(typeof(GenderEnum))]
		public string? Gender { get; set; }

        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [MaxLength(CityMaxLength)]
        public string City { get; set; } = null!;

        [MaxLength(CountryMaxLength)]
        public string Country { get; set; } = null!;
        public bool IsApproved { get; set; }
        public string? ProfilePictureUrl { get; set; }


	}
}
