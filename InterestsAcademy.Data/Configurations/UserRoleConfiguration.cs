using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(GetUserRoles());
        }

        private List<IdentityUserRole<string>> GetUserRoles()
        {
            var userRoles = new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>()
                {
                    RoleId = "78374b9b-5158-4aff-8626-d088a02d79e1",
                    UserId = "93418f37-da3b-4c78-b0ae-8f0022b09681"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "20dcf707-dfd9-4aae-b8c3-f3b9844e09d8",
                    RoleId = "835c8458-e8b7-493f-9c13-67bfcd7316a3"
                },
                new IdentityUserRole<string>()
                {
                    UserId = "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                    RoleId = "8duisjak-e8o7-8uu5-9c13-543e65731jh3"
                }
            };


            return userRoles;
        }
    }
}
