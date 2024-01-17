using Demo.Core.Models;
using MediatR;

namespace Demo.Core.Queries
{
    public class GetBlogsByIdQuery : IRequest<BlogDTO>
    {
        public int Id { get; set; }
    }
}