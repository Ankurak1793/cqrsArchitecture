using AspNetCoreRateLimit;
using Demo.Core.Interfaces;
using Demo.Infrastructure.Repositories;
using Humanizer.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Demo.Infrastructure.ServiceExtension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DbContextClass>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<IUserRepository, UserRepository>();


          
            return services;
        }
    }
}
