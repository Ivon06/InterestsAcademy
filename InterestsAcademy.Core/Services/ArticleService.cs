using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Article;
using InterestsAcademy.Core.Models.Course;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InterestsAcademy.Core.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IRepository repo;

        public ArticleService(IRepository repo)
        {
            this.repo = repo;
        }

        public async Task AddArticle(ArticleQueryViewModel model)
        {
            var article = new Article()
            {
                Name = model.Name,
                Description = model.Description,
                UserId = model.UserId,
                PublishedOn = DateTime.Now,
                ArticlePictureURLs = model.ArticlePictureURLs
            };
            await repo.AddAsync(article);
            await repo.SaveChangesAsync();
        }

        public async Task DeleteArticle(string articleId)
        {
            var article = await repo.GetByIdAsync<Article>(articleId);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<ArticleCardViewModel>> GetAllArticleCards()
        {
            var result = await repo.GetAll<Article>()
                .Include(c => c.User)
                .Select(x => new ArticleCardViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    UserId = x.UserId,
                    PublishedOn = x.PublishedOn,
                    PictureURLs=x.ArticlePictureURLs
                }
                )
                .ToListAsync();

            return result; 
        }

        public async Task<IEnumerable<ArticleCardViewModel>> GetAllArticlesAdminCards()
        {
            var result = await repo.GetAll<Article>()
               .Include(c => c.User)
               .Select(x => new ArticleCardViewModel()
               {
                   Id = x.Id,
                   Name = x.Name,
                   Description = x.Description,
                   UserId = x.UserId,
                   PublishedOn = x.PublishedOn,
                   PictureURLs = x.ArticlePictureURLs
               }
               )
               .ToListAsync();

            return result;

        }

        public async Task<AdminArticleViewModel> GetArticleForAdmin(string articleId)
        {

            var article = await repo.GetAll<Article>()
                .Include(c => c.User)
                .FirstOrDefaultAsync(c => c.Id == articleId);


            var model = new AdminArticleViewModel()
            {
                Id = articleId,
                ArticleName = article.Name,
                ArticleDescription = article.Description,
                UserName = article.User.Name,
                ArticlePublishedOn = article.PublishedOn,
                ArticlePictureURLs = article.ArticlePictureURLs
            };

            return model;
        }

        public async Task<DeleteArticleQueryModel> GetArticleForDelete(string articleId)
        {
            var article = await repo.GetByIdAsync<Article>(articleId);

            DeleteArticleQueryModel model = new DeleteArticleQueryModel()
            {
                Id = article.Id,
                Name = article.Name,
                Description = article.Description,
                PublishedOn=article.PublishedOn
              
            };

            return model;
        }

        public async Task<EditArticleViewModel> GetArticleForEdit(string id)
        {
            var article = await repo.GetByIdAsync<Article>(id);

            var teacher = await repo.GetByIdAsync<User>(article.UserId);

            EditArticleViewModel edit = new EditArticleViewModel()
            {
                Id = id,
                Name = article.Name,
                Description = article.Description,
                UserId = article.UserId,
                PublishedOn = article.PublishedOn,
                ArticlePictureURLs = article.ArticlePictureURLs,
                UserName=article.User.Name,

            };

            return edit;
        }

        public async Task<string> GetArticleIdByName(string articleName)
        {
            var result = await repo.GetAll<Article>()
                 .FirstOrDefaultAsync(c => c.Name == articleName);

            return result.Id;
        }

        public async Task<string> GetArticleNameById(string articleId)
        {
            var article = await repo.GetByIdAsync<Article>(articleId);

            return article!.Name;
        }

        public async Task<bool> IsArticleValid(string articleId)
        {
            var result = await repo.GetAll<Article>()
                .AnyAsync(c => c.Id == articleId);

            return result;
        }
    }
}
