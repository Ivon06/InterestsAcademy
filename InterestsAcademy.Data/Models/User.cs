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
using System.Diagnostics.CodeAnalysis;

namespace InterestsAcademy.Data.Models
{
	public class User : IdentityUser
	{
        public User()
        {
            //Id = Guid.NewGuid().ToString();
            IsApproved = true;
            IsActive = true;
        }

  //      [Key]
		//public string Id { get; set; } = null!;

		[Required]
		[MaxLength(UserNameMaxLength)]
		public string Name { get; set; }

		public DateTime BirthDate { get; set; }

		public DateTime RegisteredOn { get; set; }

		[EnumDataType(typeof(GenderEnum))]
		public string? Gender { get; set; }

        
        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; } 

        [MaxLength(CityMaxLength)]
        public string? City { get; set; } 

        [MaxLength(CountryMaxLength)]
        public string? Country { get; set; } 
        public bool IsActive { get; set; }

        public bool IsApproved { get; set; }
        public string? ProfilePictureUrl { get; set; }

        public ICollection<Article> Articles { get; set; } = new HashSet<Article>();
        public ICollection<UserGroup> UserGroups { get; set; } = new HashSet<UserGroup>();
        public ICollection<ChatMessage> ChatMessages { get; set; } = new HashSet<ChatMessage>();

    }
}
