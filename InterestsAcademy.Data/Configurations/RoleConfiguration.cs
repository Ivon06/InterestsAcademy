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
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(GetRoles());
        }

        private List<IdentityRole> GetRoles()
        {
            var roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = "78374b9b-5158-4aff-8626-d088a02d79e1",
                    Name = "Teacher",
                    NormalizedName = "TEACHER"

                },
                new IdentityRole()
                {
                    Id = "835c8458-e8b7-493f-9c13-67bfcd7316a3",
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                 new IdentityRole()
                {
                    Id = "8duisjak-e8o7-8uu5-9c13-543e65731jh3",
                    Name = "Student",
                    NormalizedName = "STUDENT"
                },
                  new IdentityRole()
                {
                    Id = "78wijd768-7255-4iwf-9o23-6786yet54wa3",
                    Name = "Giver",
                    NormalizedName = "GIVER"
                }
            };

            return roles;


        }
    }
}
