using project_Credentials.Domain.Models;

namespace project_Credentials.App.Interfaces
{
    public interface IJwtUtil
    {
        string GenerateIdentityJwtToken(User user, string secretKey = null);
        bool Validate(string token, string stringKey);
    }
}