using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Article;

namespace InterestsAcademy.Core.Services
{
    public class ArticleService : IArticleService
    {
        public Task AddArticle(ArticleQueryViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteArticle(string articleId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArticleCardViewModel>> GetAllArticleCards()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ArticleCardViewModel>> GetAllArticlesAdminCards()
        {
            throw new NotImplementedException();
        }

        public Task<AdminArticleViewModel> GetArticleForAdmin(string articleId)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteArticleQueryModel> GetArticleForDelete(string articleId)
        {
            throw new NotImplementedException();
        }

        public Task<EditArticleViewModel> GetArticleForEdit(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetArticleIdByName(string articleName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetArticleNameById(string articleId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsArticleValid(string articleId)
        {
            throw new NotImplementedException();
        }
    }
}
