using Demo.Core.Interfaces;
using Demo.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure.Repositories
{
    public class BlogRepository : GenericRepository<BlogDTO>, IBlogRepository
    {
        public BlogRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

        public async Task<BlogDTO?> GetBlogById(int blogId)
        {
             return _dbContext.Blogs.Include(x => x.Comments).FirstOrDefault(x => x.Id == blogId);
        }
        
    }
}
