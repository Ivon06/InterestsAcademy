using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Models.Blog
{
    public class PostViewModel
    {
        public PostViewModel()
        {
            CarouselPhotosUrls = new List<string>();
            Posts = new();
        }
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime PublishedOn { get; set; }
        
        public string HeadImageUrl { get; set; } = null!;
        public List<string> CarouselPhotosUrls { get; set; }
        public List<PostViewModel> Posts { get; set; }
    }
}
