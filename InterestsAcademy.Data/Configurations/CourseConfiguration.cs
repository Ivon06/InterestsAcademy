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
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(GetCourse());
        }

        private List<Course> GetCourse()
        {
            return new List<Course>()
            {
                new Course()
                {
                Id ="e6bb13af-fe1e-4276-b301-1bffe7f8c8fc",
                Name="Биология",
                TeacherId = "2644afb5-f916-4b3f-b451-9ff86c881de3",
                RoomId = "64ae1f9e-bc59-4356-b74e-887f08425106",
                Duration = "2 месеца",
                Description = "Този курс обхваща основите на биологията – от клетките и ДНК до екосистемите и еволюцията. Ще разгледаме структурата и функциите на организмите, взаимодействията в природата и научните методи в биологията. Курсът включва практически примери и дискусии за съвременни биотехнологии и екологични предизвикателства. Подходящ е за ученици, студенти и любители на науката, които искат да разширят знанията си и да разберат по-добре живата природа. ",
                IsActive = true,
                IsApproved = true,
                }

            };
        }
    }
}
