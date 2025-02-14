using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Article;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace InterestsAcademy.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleservice)
        {
            _articleService = articleservice;
        }
        public async Task<IActionResult> AllNews()
        {
            IEnumerable<ArticleCardViewModel> model = new List<ArticleCardViewModel>();
            model = await _articleService.GetAllArticleCards();
            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
