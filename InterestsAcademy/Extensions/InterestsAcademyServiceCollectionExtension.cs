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

            return services;
        }
    }
}
