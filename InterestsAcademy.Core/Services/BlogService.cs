using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Models.Blog;
using InterestsAcademy.Data.Models;
using InterestsAcademy.Data.Repository.Contracts;
using MailKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestsAcademy.Core.Services
{
    public class BlogService : IBlogService
    {
        private readonly IImageService imageService;
        private readonly IRepository repo;
        public BlogService(IImageService imageService, IRepository repo)
        {
            this.imageService = imageService;
            this.repo = repo;
        }

        public async Task CreatePostAsync(CreatePostQueryModel model)
        {
            var post = new Article()
            {
               
                Name = model.Topic,
                Description = model.Content,
                PublishedOn = model.CreatedOn
            };

            var photos = new List<Photo>();

            foreach (var image in model.CarouselPhotos)
            {
                var photo = new Photo();
                photo.PhotoUrl = await imageService.UploadImageAsync(image, "projectImages", image.FileName);
                photo.ArticleId = post.Id; 
                await repo.AddAsync(photo);


            }

           
            await repo.AddAsync(post);
            await repo.SaveChangesAsync();
        }

        public async Task<PostViewModel> GetPostAsync(string postId)
        {
            var post = await repo.GetAll<Article>()
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    PublishedOn = p.PublishedOn,
                    
                })
                 .FirstOrDefaultAsync(p => p.Id == postId);

            post.CarouselPhotosUrls = await GetAllPostPhotosAsync(post.Id);

            return post;
        }

        public async Task<List<PostViewModel>> GetAllPostAsync(int skipCount)
        {
            var posts = await repo.GetAll<Article>()
                .OrderByDescending(p => p.PublishedOn)
                .Skip(skipCount)
                .Take(8)
                .Select(p => new PostViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    PublishedOn = p.PublishedOn,

                })
                .ToListAsync();

            foreach (var post in posts)
            {
                post.CarouselPhotosUrls = await GetAllPostPhotosAsync(post.Id);
                post.HeadImageUrl = post.CarouselPhotosUrls.FirstOrDefault()!;

            }

            return posts;
        }

        public async Task<List<string>> GetAllPostPhotosAsync(string postId)
        {
            var urls = await repo.GetAll<Photo>()
                .Where(pp => pp.ArticleId == postId)
                .Select(pp => pp.PhotoUrl)
                .ToListAsync();

            return urls;

        }

        public async Task<bool> IsPostExistById(string postId)
        {
            bool result = await repo.GetAll<Article>().AnyAsync(p => p.Id == postId);
            return result;
        }

        public async Task<int> AllPostsCountAsync()
        {
            var count = await repo.GetAll<Article>().CountAsync();

            return count;
        }
    }
}
