using AutoMapper;
using Demo.Core.Interfaces;
using Demo.Core.Models;
using Demo.Core.ViewModels;
using Demo.Services.Interfaces;
using Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        private readonly IBlogRepository _blogRepository;

        private readonly IMapper _mapper;

        public CommentService(ICommentRepository commentRepository, IBlogRepository blogRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<bool> CreateComment(CommentsViewModel model)
        {
            if (model != null)
            {
                var commentDetails = _mapper.Map<CommentDTO>(model);
                var blog = await _blogRepository.GetById(model.BlogId);
                commentDetails.Blogs = blog;
                await _commentRepository.Add(commentDetails);
                var result = _commentRepository.Save();
                return result > 0;
            }
            return false;
        }

    }
}
