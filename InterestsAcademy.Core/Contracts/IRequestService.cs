using InterestsAcademy.Core.Models.Request;
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

        Task<RequestViewModel> GetAllRequestByCourseIdAsync(string courseId);

        Task<string> Create(CreateRequestModel model);
    }
}
