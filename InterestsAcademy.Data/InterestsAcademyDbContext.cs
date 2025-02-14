using InterestsAcademy.Data.Configurations;
using InterestsAcademy.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data
{
    public class InterestsAcademyDbContext : IdentityDbContext<User>
    {
        private bool seedDb;
        public InterestsAcademyDbContext(DbContextOptions<InterestsAcademyDbContext> options, bool seedDb = true)
            : base(options)
        {

            if (this.Database.IsRelational())
            {
                this.Database.Migrate();
            }
            else
            {
                this.Database.EnsureCreated();
            }

            this.seedDb = seedDb;

        }

        protected InterestsAcademyDbContext()
        {
        }

        //add trips

        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityStudent> ActivityStudents { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<GivenThing> GivenThings { get; set; }
        public DbSet<Giver> Givers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<MaterialBaseItem> MaterialBaseItems { get; set; }
        public DbSet<SleepingRoom> SleepingRooms { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentCourse> StudentsCourses { get; set; }
        public DbSet<Request> Requests { get;set; }
        public DbSet<Article> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
               .Property(u => u.BirthDate)
               .HasColumnType("DATE");

            builder.Entity<User>()
                .HasMany(a => a.Articles)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.Entity<ActivityStudent>()
                .HasKey(a => new { a.StudentId, a.ActivityId });

            builder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Entity<Course>()
    .Property(t => t.RoomId)
    .HasColumnName("RoomId");


            builder.Entity<Course>()
    .Property(t => t.Description)
    .HasColumnName("Description");

            builder.Entity<Activity>()
                .HasMany(a => a.ActivityStudents)
                .WithOne(a => a.Activity)
                .HasForeignKey(a => a.ActivityId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Student>()
                .HasMany(a => a.ActivitiesStudents)
                .WithOne(a => a.Student)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Giver>()
                .HasMany(g => g.GivenThings)
                .WithOne(g => g.Giver)
                .HasForeignKey(g => g.GiverId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder.Entity<MaterialBaseItem>()
            //    .HasMany(g => g.GivenThings)
            //    .WithOne(g => g.MaterialBaseItem)
            //    .HasForeignKey(g => g.MaterialItemId)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Course>()
                .HasMany(a => a.StudentCourses)
                .WithOne(a => a.Course)
                .HasForeignKey(a => a.CourseId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Student>()
                .HasMany(a => a.StudentCourses)
                .WithOne(a => a.Student)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Course>()
                .HasOne(c => c.Room)
                .WithMany(c => c.Courses)
                .HasForeignKey(c => c.RoomId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Student>()
                .HasMany(s => s.Requests)
                .WithOne(r => r.Student)
                .HasForeignKey(r => r.StudentId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Teacher>()
               .HasMany(s => s.Requests)
               .WithOne(r => r.Teacher)
               .HasForeignKey(r => r.TeacherId)
               .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Course>()
               .HasMany(s => s.Requests)
               .WithOne(r => r.Course)
               .HasForeignKey(r => r.CourseId)
               .OnDelete(DeleteBehavior.NoAction);
            
            if (seedDb)
            {
                builder.ApplyConfiguration(new RoomConfiguration());
                builder.ApplyConfiguration(new RoleConfiguration());
                builder.ApplyConfiguration(new UserConfiguration());
                builder.ApplyConfiguration(new UserRoleConfiguration());
                builder.ApplyConfiguration(new StudentConfiguration());
                builder.ApplyConfiguration(new TeacherConfiguration());
                builder.ApplyConfiguration(new CourseConfiguration());
            }

            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

    }
}
