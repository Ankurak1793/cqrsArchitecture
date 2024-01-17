using Demo.Core.Commands;
using Demo.Core.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : BaseController
    {
        private readonly IMediator mediator;

        public CommentsController(IMediator mediator)
        {
            this.mediator = mediator;
        }
       
        /// <summary>
        /// Add a comment
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateComment(CommentsViewModel model)
        {
            var isCommentCreated = await mediator.Send(new CreateCommentCommand(
                   model.BlogId,
                   model.Comment
                  ));
            return isCommentCreated ? HandleResponse(isCommentCreated) : BadRequest();
        }
    }
}