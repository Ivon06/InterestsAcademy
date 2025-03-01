﻿using InterestsAcademy.Core.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IRequestService
    {
        Task<RequestViewModel> GetRequestByIdAsync( string requestId);

        Task<List<RequestViewModel>> GetAllRequestByCourseIdAsync(string courseId);

        Task<string> Create(CreateRequestModel model);
        Task<bool> EditStatus(string newStatus, string requestId);

        Task<List<RequestViewModel>> GetAllRequestAsync();
        Task<string> GetRequestStatusByStudentsIdAndCourseID(string studentId, string courseId);
    }
}
