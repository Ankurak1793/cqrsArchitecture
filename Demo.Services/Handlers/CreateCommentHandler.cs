using Demo.Core.Commands;
using Demo.Core.ViewModels;
using Demo.Services.Interfaces;
using MediatR;

namespace Demo.Services.Handlers
{
    public class CreateCommentHandler : IRequestHandler<CreateCommentCommand, bool>
    {
        private readonly ICommentService _commentService;

        public CreateCommentHandler(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public async Task<bool> Handle(CreateCommentCommand command, CancellationToken cancellationToken)
        {
            var commentDetails = new CommentsViewModel()
            {
                BlogId = command.BlogId,
                Comment = command.Comment
            };

            return await _commentService.CreateComment(commentDetails);
        }
    }
}
