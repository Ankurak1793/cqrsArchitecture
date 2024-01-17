using AutoMapper;
using Demo.Core.Interfaces;
using Demo.Core.Models;
using Demo.Services.Interfaces;
using Demo.ViewModels;

namespace Demo.Services
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _blogRepository;

        private readonly IMapper _mapper;

        public BlogService(IBlogRepository blogRepository,IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateBlog(BlogViewModel model)
        {
            if (model != null)
            {
                var blogDetails = _mapper.Map<BlogDTO>(model);
                await _blogRepository.Add(blogDetails);
               var result =  _blogRepository.Save();
                return result > 0;
            }
            return false;
        }
      
        public async Task<BlogDTO> GetBlogById(int blogId)
        {
            if (blogId > 0)
            {
                var blogDetails = await _blogRepository.GetBlogById(blogId);
                if (blogDetails != null)
                {
                    return blogDetails;
                }
            }
            return null;
        }

    }
}
