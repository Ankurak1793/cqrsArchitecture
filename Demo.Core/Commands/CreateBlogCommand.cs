using Demo.ViewModels;
using MediatR;

namespace Demo.Core.Commands
{
    public class CreateBlogCommand : IRequest<bool>
    {
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public CreateBlogCommand(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }
}
