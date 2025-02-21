using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Request;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class RequestService : IRequestService
    {
        private readonly IRepository repo;

        public RequestService(IRepository repo)
        {
            this.repo = repo;
        }



        public async Task<RequestViewModel> GetRequestByIdAsync(string requestId)
        {
            var request = await repo.GetAll<Request>()
                .Where(r => r.Id == requestId)
                .Include(r => r.Course)
                .Include(r => r.Course.Teacher!)
                .Include(r => r.Student)
                .Include(r => r.Student.User)
                .Select(r => new RequestViewModel()
                {
                    Id = requestId,
                    CourseId = r.CourseId,
                    Status = r.Status,
                    TeacherId = r.Course.TeacherId,
                    StudentEmail = r.Student.User.Email,
                    StudentName = r.Student.User.Name

                })
                .FirstOrDefaultAsync();

            return request;
        }

        public async Task<List<RequestViewModel>> GetAllRequestByCourseIdAsync(string courseId)
        {
            var request = await repo.GetAll<Request>()
                .Where(r => r.CourseId == courseId)
                .Include(r => r.Course)
                .Include(r => r.Course.Teacher!)
                .Include(r => r.Student)
                .Include(r => r.Student.User)
                .Select(r => new RequestViewModel()
                {
                    Id = r.Id,
                    CourseId = r.CourseId,
                    Status = r.Status,
                    TeacherId = r.Course.TeacherId,
                    StudentEmail = r.Student.User.Email,
                    StudentName = r.Student.User.Name

                })
                .ToListAsync();

            return request!;
        }

        public async Task<List<RequestViewModel>> GetAllRequestAsync()
        {
            var request = await repo.GetAll<Request>()
                
                .Include(r => r.Course)
                .Include(r => r.Course.Teacher!)
                .Include(r => r.Student)
                .Include(r => r.Student.User)
                .Select(r => new RequestViewModel()
                {
                    Id = r.Id,
                    CourseId = r.CourseId,
                    Status = r.Status,
                    TeacherId = r.Course.TeacherId,
                    StudentEmail = r.Student.User.Email,
                    StudentName = r.Student.User.Name

                })
                .ToListAsync();

            return request!;
        }

        
        public async Task<string> Create(CreateRequestModel model)
        {
            var request = new Request()
            {
                CourseId = model.CourseId,
                Status = model.Status,
                StudentId = model.StudentId,
                TeacherId = model.TeacherId,
            };

            await repo.AddAsync(request);
            await repo.SaveChangesAsync();

            return request.Id;
        }

        public async Task<bool> EditStatus(string newStatus, string requestId)
        {
            var request = await repo.GetByIdAsync<Request>(requestId);

            if (request != null)
            {
                request.Status = newStatus;
                await repo.SaveChangesAsync();
                return true;
            }

            return false;


        }

        public async Task<string> GetRequestStatusByStudentsIdAndCourseID(string studentId, string courseId)
        {
            var request = await repo.GetAll<Request>()
                .Where(r => r.StudentId == studentId && r.CourseId == courseId)
                .Select(r => r.Status)
                .FirstOrDefaultAsync();
            return request;
        }
    }
}
