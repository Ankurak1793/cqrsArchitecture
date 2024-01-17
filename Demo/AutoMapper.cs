using AutoMapper;
using Demo.Core.Models;
using Demo.Core.ViewModels;
using Demo.ViewModels;

namespace Demo
{
    public class AutoMapper : Profile {

        public AutoMapper() { 

            CreateMap<UserViewModel, ApplicationUserDTO>();
            CreateMap<ApplicationUserDTO, UserViewModel>();

            CreateMap<CommentsViewModel, CommentDTO>();
            CreateMap<CommentDTO, CommentsViewModel>();

            CreateMap<BlogViewModel, BlogDTO>();
            CreateMap<BlogDTO, BlogViewModel>();

            CreateMap<ApplicationUserDTO, UserWithRolesViewModel>();

            CreateMap<ApplicationUserDTO, UserWithRolesViewModel>();
           

        }
    }
}