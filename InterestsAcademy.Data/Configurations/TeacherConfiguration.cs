using InterestsAcademy.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data.Configurations
{
    public class TeacherConfiguration :IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(GetTeachers());
        }

        public List<Teacher> GetTeachers()
        {
            var teachers = new List<Teacher>();

            teachers.Add(new Teacher()
            {
                Id = "2644afb5-f916-4b3f-b451-9ff86c881de3",
                UserId = "93418f37-da3b-4c78-b0ae-8f0022b09681",
            });

            return teachers;
        }
    }
}
