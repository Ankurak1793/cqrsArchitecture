using Demo.Core.Commands;
using Demo.Services.Interfaces;
using Demo.ViewModels;
using MediatR;

namespace Demo.Services.Handlers
{
    public class CreateBlogHandler : IRequestHandler<CreateBlogCommand, bool>
    {
        private readonly IBlogService _blogService;

        public CreateBlogHandler(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<bool> Handle(CreateBlogCommand command, CancellationToken cancellationToken)
        {
            var studentDetails = new BlogViewModel()
            {
                Name = command.Name,
                Content = command.Content
            };

            return await _blogService.CreateBlog(studentDetails);
        }
    }
}
