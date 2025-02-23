using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Article
{
    public class CreateArticleQueryModel
    {
        public string Id { get; set; } = null!;
        public string Topic { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public IFormFile HeadImage { get; set; } = null!;
        public List<IFormFile> CarouselPhotos { get; set; }
    }
}
