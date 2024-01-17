using AutoMapper;
using Demo.Core.Models;
using Demo.Core.Queries;
using Demo.Services.Interfaces;
using MediatR;

namespace Demo.Services.Handlers
{
    public class GetBlogByIdHandler : IRequestHandler<GetBlogsByIdQuery, BlogDTO>
    {
        private readonly IBlogService _blogService;

        public GetBlogByIdHandler(IBlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<BlogDTO> Handle(GetBlogsByIdQuery query, CancellationToken cancellationToken)
        {
            var result = await _blogService.GetBlogById(query.Id);
            return result;
        }
    }
}
