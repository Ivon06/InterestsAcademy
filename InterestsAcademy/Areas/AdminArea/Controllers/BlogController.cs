using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Article;
using InterestsAcademy.Core.Models.Blog;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Extensions;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;

namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class BlogController : BaseController
    {
        private readonly IBlogService blogService;

        public BlogController(IBlogService blogService)
        {
            this.blogService = blogService;
        }

        [HttpPost]
        [Route("/Blog/CreatePost")]
        public async Task<IActionResult> CreatePost(string topic, string content, List<IFormFile> photos)
        {
            string userId = User.GetId();



            var model = new CreatePostQueryModel()
            {
                Topic = topic,
                Content = content,
                CreatedOn = DateTime.Now,
                CarouselPhotos = photos.ToList(),
            };

            await blogService.CreatePostAsync(model);

            return new JsonResult(new { isCompany = true, model });
        }


        public async Task<IActionResult> All(int skipCount = 0)
        {
            var posts = await blogService.GetAllPostAsync(skipCount);
            var totalPostsCount = await blogService.AllPostsCountAsync();

            var model = new BlogViewModel()
            {
                Posts = posts,
                PagesCount = totalPostsCount % 8 != 0 ? totalPostsCount / 8 + 1 : totalPostsCount / 8,
                SkipCount = skipCount
            };

            return View(model);
        }


        public async Task<IActionResult> PostDetails(string postId)
        {
            bool exist = await blogService.IsPostExistById(postId);
            if (!exist)
            {
                TempData[ErrorMessage] = "Този пост не съществува.";
                return RedirectToAction("BlogHome");
            }

            var model = await blogService.GetPostAsync(postId);
            model.Posts = await blogService.GetAllPostAsync(0);

            return View(model);
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
