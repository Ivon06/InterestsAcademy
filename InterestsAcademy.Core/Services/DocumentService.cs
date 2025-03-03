using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterestsAcademy.Core.Contracts;

namespace InterestsAcademy.Core.Services
{
    public class DocumentService : IDocumentService
    {
        private Cloudinary cloudinary;
        private readonly IRepository repo;

        public DocumentService(Cloudinary cloudinary, IRepository repo)
        {
            this.cloudinary = cloudinary;
            this.repo = repo;
        }

        public async Task<string> UploadDocumentAsync(IFormFile file, string folder)
        {
            using var stream = file.OpenReadStream();

            var uploadParams = new RawUploadParams()
            {
                File = new FileDescription(file.FileName, stream),
                Folder = folder,

            };

            var uploadResult = await cloudinary.UploadAsync(uploadParams);

            if (uploadResult.Error != null)
            {
                throw new InvalidOperationException(uploadResult.Error.Message);
            }

            return uploadResult.SecureUrl.ToString();

        }

    }
}
