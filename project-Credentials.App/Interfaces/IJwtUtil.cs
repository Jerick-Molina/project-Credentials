using project_Credentials.Domain.Models;

namespace project_Credentials.App.Features.Utils
{
    public interface IJwtUtil
    {
        string GenerateIdentityJwtToken(User user, string secretKey = null);
        bool Validate(string token, string stringKey);
    }
}