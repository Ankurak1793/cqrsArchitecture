﻿using Demo.Core.ViewModels;
using Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Services.Interfaces
{
    public interface ICommentService
    {
        Task<bool> CreateComment(CommentsViewModel commentsViewModel);
    }
}
