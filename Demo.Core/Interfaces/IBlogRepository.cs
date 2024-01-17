using Demo.Core.Models;

namespace Demo.Core.Interfaces
{
    public interface IBlogRepository :  IGenericRepository<BlogDTO>
    {
        Task<BlogDTO?> GetBlogById (int blogId);
    }
}
