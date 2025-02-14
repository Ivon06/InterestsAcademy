using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterestsAcademy.Core.Models.Article;

namespace InterestsAcademy.Core.Contracts
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleCardViewModel>> GetAllArticleCards();
        Task AddArticle(ArticleQueryViewModel model);
        Task DeleteArticle(string articleId);
        Task<DeleteArticleQueryModel> GetArticleForDelete(string articleId);
        Task<bool> IsArticleValid(string articleId);
        Task<string> GetArticleNameById(string articleId);
        Task<string> GetArticleIdByName(string articleName);
        Task<EditArticleViewModel> GetArticleForEdit(string id);
        Task<IEnumerable<ArticleCardViewModel>> GetAllArticlesAdminCards();
        Task<AdminArticleViewModel> GetArticleForAdmin(string articleId);


    }
}
