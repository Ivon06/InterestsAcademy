using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Core.Models.Request;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class CourseService : ICourseService
    {
        private readonly IRepository repo;
        private readonly IRequestService requestService;
        private readonly IRoomService roomService;

        public CourseService(IRepository repo, IRequestService requestService, IRoomService roomService)
        {
            this.repo = repo;
            this.requestService = requestService;
            this.roomService = roomService;
        }

        public async Task AddCourse(CourseQueryModel model)
        {
            var course = new Course()
            {
                Name = model.Name,
                Description = model.Description,
                TeacherId = model.TeacherId,
                Duration = model.Duration,
                IsApproved = false
            };

            await repo.AddAsync(course);
            await repo.SaveChangesAsync();
        }

        public async Task<bool> ApproveCourse(EditCourseViewModel model)
        {
            var course = await repo.GetByIdAsync<Course>(model.Id);

            course.IsApproved = true;
            course.RoomId = model.RoomId;


            await repo.SaveChangesAsync();

            if (course.IsApproved)
                return true;

            else return false;
        }

        public async Task<AllRequestViewModel> GetCourseWithAllRequest(string courseId)
        {
            var requests = await requestService.GetAllRequestByCourseIdAsync(courseId);

            var course = await repo.GetAll<Course>()
                .Include(c => c.Teacher.User)
                .FirstOrDefaultAsync(c => c.Id == courseId);


            var model = new AllRequestViewModel()
            {
                CourseName = course.Name,
                CourseDescription = course.Description,
                TeacherName = course.Teacher.User.Name,
                CourseDuration = course.Duration,
                Requests = requests,
                IsApproved = course.IsApproved,
                RoomId = course.RoomId
            };

            return model;
        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllCoursesCards()
        {
            var result = await repo.GetAll<Course>()
                .Include(c => c.Teacher)
                .Where(c => c.IsApproved && c.IsActive)
                .Select(x => new CourseCardViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    TeacherId = x.TeacherId,
                    RoomId = x.RoomId,
                    TeacherUserId = x.Teacher.UserId
                }
                )
                .ToListAsync();

            return result;


        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllStudentCoursesCards(string studentId)
        {
            var result = await repo.GetAll<StudentCourse>()
                 .Include(c => c.Student)
                 .Include(c => c.Course)
                 .Include(c => c.Course.Teacher)
                 .Where(c => c.IsApproved == true && c.StudentId == studentId)
                 .Select(x => new CourseCardViewModel()
                 {
                     Id = x.Course.Id,
                     Name = x.Course.Name,
                     Description = x.Course.Description,
                     TeacherId = x.Course.TeacherId,
                     RoomId = x.Course.RoomId,
                     TeacherUserId = x.Course.Teacher.UserId
                 }
                 )
                 .ToListAsync();

            return result;
        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllTeacherCourses(string teacherId)
        {
            var result = await repo.GetAll<Course>()
                .Include(c => c.Teacher)
                .Where(c => c.TeacherId == teacherId)
                 .Select(x => new CourseCardViewModel()
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Description = x.Description,
                     TeacherId = x.TeacherId,
                     IsApproved = x.IsApproved,
                     RoomId = x.RoomId,
                     TeacherUserId = x.Teacher.UserId

                 }
                 )
                 .ToListAsync();

            return result;
        }

        public async Task<bool> IsCourseValid(string courseId)
        {
            var result = await repo.GetAll<Course>()
                .AnyAsync(c => c.Id == courseId);

            return result;
        }

        public async Task<string> GetCourseNameById(string courseId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);

            return course!.Name;

        }



        public async Task<string> GetCourseIdByName(string courseName)
        {
            var result = await repo.GetAll<Course>()
                .FirstOrDefaultAsync(c => c.Name == courseName);

            return result.Id;
        }

        public async Task AddStudentToCourse(string studentId, string courseId)
        {
            StudentCourse sc = new StudentCourse()
            {
                StudentId = studentId,
                CourseId = courseId,
                IsApproved = true
            };

            await repo.AddAsync(sc);
            await repo.SaveChangesAsync();

        }

        public async Task<string> GetCourseIdByRequestId(string requestId)
        {
            var result = await repo.GetByIdAsync<Request>(requestId);

            return result.CourseId;

        }

        public async Task<EditCourseViewModel> GetCourseForEdit(string id)
        {
            var course = await repo.GetByIdAsync<Course>(id);

            var teacher = await repo.GetByIdAsync<Teacher>(course.TeacherId);

            var teacherUser = await repo.GetByIdAsync<User>(teacher.UserId);

            EditCourseViewModel edit = new EditCourseViewModel()
            {
                Id = id,
                Name = course.Name,
                Description = course.Description,
                TeacherId = course.TeacherId,
                RoomId = course.RoomId,
                Duration = course.Duration,
                TeacherName = teacherUser.Name

            };

            return edit;
        }

        public async Task<bool> IsCourseApproved(string courseId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);

            return course.IsApproved;
        }

        public async Task<bool> IsCourseValidForTeacher(string courseId, string teacherId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);

            return course.TeacherId == teacherId;
        }

        public async Task<List<CourseCardViewModel>> GetAllCoursesByRoomId(string roomId)
        {
            var result = await repo.GetAll<Course>()
                .Where(c => c.RoomId == roomId)
                .Select(x => new CourseCardViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    TeacherId = x.TeacherId,
                    RoomId = x.RoomId,

                }
                )
                .ToListAsync();
            return result;
        }

        public async Task<AdminCourseViewModel> GetCourseForAdmin(string courseId)
        {
            var requests = await requestService.GetAllRequestByCourseIdAsync(courseId);

            var course = await repo.GetAll<Course>()
                .Include(c => c.Teacher.User)
                .FirstOrDefaultAsync(c => c.Id == courseId);


            var model = new AdminCourseViewModel()
            {
                Id = courseId,
                CourseName = course.Name,
                CourseDescription = course.Description,
                TeacherName = course.Teacher.User.Name,
                CourseDuration = course.Duration,
                Requests = requests,
                IsApproved = course.IsApproved,
                RoomId = course.RoomId,
            };

            model.Rooms = await roomService.GetAllRooms();

            string room = await roomService.GetRoomNameByIdAsync(model.RoomId);

            model.RoomName = room;

            return model;
        }

        public async Task SetRoomForCourse(string roomId, string courseId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);

            course.RoomId = roomId;

            await repo.SaveChangesAsync();
        }

        public async Task<DeleteCourseQueryModel> GetCourseForDelete(string courseId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);

            DeleteCourseQueryModel model = new DeleteCourseQueryModel()
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description,
               
                Duration = course.Duration
            };

            return model;
        }

        public async Task DeleteCourse(string courseId)
        {
            var course = await repo.GetByIdAsync<Course>(courseId);

            course.IsActive = false;
        }

        public async Task<IEnumerable<CourseCardViewModel>> GetAllCoursesAdminCards()
        {
            var result = await repo.GetAll<Course>()
                .Include(c => c.Teacher)
                .Where(c => c.IsActive)
                .Select(x => new CourseCardViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    TeacherId = x.TeacherId,
                    RoomId = x.RoomId,
                    TeacherUserId = x.Teacher.UserId
                }
                )
                .ToListAsync();

            return result;


        }
    }
}
