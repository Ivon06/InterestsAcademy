using InterestsAcademy.Data.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Contracts
{
	public interface IImageService
	{
		Task<string> UploadImage(IFormFile imageFile, string nameFolder, User user);

		Task<string> UploadImageAsync(IFormFile imageFile, string folderName, string name);
	}
}
