using InterestsAcademy.Core.Contracts;
using InterestsAcademy.Core.Services;
using InterestsAcademy.Data.Repository;
using InterestsAcademy.Data.Repository.Contracts;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace InterestsAcademy.Extensions
{
    public static class InterestsAcademyServiceCollectionExtension
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IImageService, ImageService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<ITeacherService, TeacherService>();
            services.AddScoped<IRequestService,RequestService>();   
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IDonationService, DonationService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<IBlogService,BlogService>();
            services.AddScoped<IGroupService, GroupService>();
            services.AddScoped<IPrivateChatService,PrivateChatService>();


            return services;
        }
    }
}
