using Demo.Core.Models;
using Demo.Core.ViewModels;

namespace Demo.Core.Interfaces
{
    public interface IUserRepository : IGenericRepository<ApplicationUserDTO>
    {
        Task<ApplicationUserDTO?> AuthenticateUser(LoginViewModel model);
    }
}
