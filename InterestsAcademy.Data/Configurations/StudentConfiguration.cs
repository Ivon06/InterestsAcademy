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
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(GetStudents());
        }

        private List<Student> GetStudents()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    UserId = "080a469a-b5a2-44cc-a660-eea8e6fd05a5",
                    
                },
            };

            return students;
        }
    }
}
