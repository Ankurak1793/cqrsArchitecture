using Demo.Core.Commands;
using Demo.Core.Queries;
using Demo.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : BaseController
    {
        private readonly IMediator mediator;
        public BlogController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Get blog by id
        /// </summary>
        /// <param name="blogId"></param>
        /// <returns></returns>
        [HttpGet("{blogId}")]
        public async Task<IActionResult> GetBlogById(int blogId)
        {
            var blogDetails = await mediator.Send(new GetBlogsByIdQuery() { Id = blogId  });
            return blogDetails != null ? HandleResponse(blogDetails) : NotFound();
        }

        /// <summary>
        /// Add a blog
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateBlog(BlogViewModel model)
        {
            var isblogCreated = await mediator.Send(new CreateBlogCommand(
                model.Name ,
                model.Content
               ));
            return isblogCreated ? HandleResponse(isblogCreated) : BadRequest();
        }

    }
}
