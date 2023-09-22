
using project_Credentials.Domain.Models;

namespace project_Credentials.Repository.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User user);
        Task<User?> GetUserByEmail(string email);
    }
}