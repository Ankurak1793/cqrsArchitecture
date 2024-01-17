using Demo.Core.Interfaces;
using Demo.Core.Models;

namespace Demo.Infrastructure.Repositories
{
    public class CommentRepository : GenericRepository<CommentDTO>, ICommentRepository
    {
        public CommentRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

    }
}
