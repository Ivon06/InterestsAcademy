using InterestsAcademy.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Data
{
	public class InterestsAcademyDbContext : IdentityDbContext<User>
	{
		public InterestsAcademyDbContext(DbContextOptions options) : base(options)
		{
		}

		protected InterestsAcademyDbContext()
		{
		}

		public DbSet<Activity> Activities { get; set; }
		public DbSet<ActivityStudent> ActivityStudents { get; set; }
		public DbSet<Course> Courses { get; set; }
		public DbSet<CourseGiver> CoursesGivers { get; set; }
		public DbSet<GivenThing> GivenThings { get; set; }
		public DbSet<Giver> Givers { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<RoomGiver> RoomsGivers { get; set; }
		public DbSet<SleepingRoom> SleepingRooms { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		//test
		 
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<User>()
			   .Property(u => u.BirthDate)
			   .HasColumnType("DATE");

			builder.Entity<ActivityStudent>()
				.HasKey(a => new { a.StudentId, a.ActivityId });

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

			builder.Entity<Room>()
				.HasMany(r => r.RoomGivers)
				.WithOne(r => r.Room)
				.HasForeignKey(r => r.RoomId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<Giver>()
				.HasMany(g => g.RoomGivers)
				.WithOne(g => g.Giver)
				.HasForeignKey(g => g.GiverId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<Course>()
				.HasMany(r => r.CourseGivers)
				.WithOne(r => r.Course)
				.HasForeignKey(r => r.CourseId)
				.OnDelete(DeleteBehavior.NoAction);

			builder.Entity<Giver>()
				.HasMany(g => g.CourseGivers)
				.WithOne(g => g.Giver)
				.HasForeignKey(g => g.GiverId)
				.OnDelete(DeleteBehavior.NoAction);

		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

	}
}
