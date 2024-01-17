using Demo.Core.Models;
using Demo.ViewModels;

namespace Demo.Services.Interfaces
{
    public interface IBlogService
    {
        Task<bool> CreateBlog(BlogViewModel blogViewModel);

        Task<BlogDTO> GetBlogById(int blogId);
    }
}
