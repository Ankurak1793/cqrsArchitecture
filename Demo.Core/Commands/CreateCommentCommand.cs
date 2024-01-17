using Demo.ViewModels;
using MediatR;

namespace Demo.Core.Commands
{
    public class CreateCommentCommand : IRequest<bool>
    {
        public int BlogId { get; set; }
        public string Comment { get; set; } = string.Empty;

        public CreateCommentCommand(int blogId, string comment)
        {
            BlogId = blogId;
            Comment = comment;
        }
    }
}
