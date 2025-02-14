using InterestsAcademy.Common;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Article;
using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Core.Services;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using static InterestsAcademy.Common.Notifications;


namespace InterestsAcademy.Areas.AdminArea.Controllers
{
    public class ArticleController : BaseController
    {
        private readonly IArticleService articleService;

        public ArticleController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        [HttpGet]
        public async Task<IActionResult> DeleteArticle(string articleId)
        {
            bool isArticleValid = await articleService.IsArticleValid(articleId);

            if (!isArticleValid)
            {
                TempData[ErrorMessage] = "Тази новина не съществува.";
                return RedirectToAction("Index", "Home");
            }

            var model = await articleService.GetArticleForDelete(articleId);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(DeleteArticleQueryModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Неправилни данни.";
                return View("DeleteArticle", model);
            }

            if (!User.IsInRole("Admin"))
            {
                TempData[ErrorMessage] = "Трябва да сте админ, за да изтриете новина.";
                return RedirectToAction("Index", "Home");
            }

            await articleService.DeleteArticle(model.Id);

            TempData[SuccessMessage] = "Успешно изтрита новина .";
            return RedirectToAction("All", "Article", new { Area = "AdminArea" });

        }
        public async Task<IActionResult> All()
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData[ErrorMessage] = "Трябва да се регистрирате, за да достъпите тази функция.";
                return RedirectToAction("Index", "Home");
            }



            var model = await articleService.GetAllArticlesAdminCards();

            return View(model);
        }
        public async Task<IActionResult> Info(string id)
        {
            bool isValidArticle = await articleService.IsArticleValid(id);
            if (!isValidArticle)
            {
                TempData[ErrorMessage] = "Този новина не съществува";
                return RedirectToAction("All", "Article");
            }
            var model = await articleService.GetArticleForAdmin(id);
            return View(model);
        }

        public IActionResult Index()
        {
            return RedirectToAction("All");
        }
    }
}
