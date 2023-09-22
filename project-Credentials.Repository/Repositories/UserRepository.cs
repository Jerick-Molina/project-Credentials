
using project_Credentials.App.Interfaces;
using project_Credentials.Domain.Models;


namespace project_Credentials.Repository.Repositories;

public class UserRepository : IUserRepository
{
    private readonly ISqlDataContext _db;

    public UserRepository(ISqlDataContext db)
    {
        _db = db;
    }

    public async Task AddUser(User user)
    {
        await _db.SaveData("dbo.spUser_InsertNewUser", new { user.Email, user.Password, user.FirstName, user.LastName, user.PhoneNumber, user.IsTwoAuthen });
    }

    public async Task<User?> GetUserByEmail(string email)
    {
        var response = await _db.LoadData<User, dynamic>("dbo.spUser_GetByEmail", new { Email = email });
        return response.FirstOrDefault();
    }
}
