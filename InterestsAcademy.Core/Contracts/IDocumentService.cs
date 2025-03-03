using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
    public interface IDocumentService
    {
        Task<string> UploadDocumentAsync(IFormFile file, string folder);
    }
}
