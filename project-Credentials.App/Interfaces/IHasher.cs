namespace project_Credentials.App.Features.Utils
{
    public interface IHasher
    {
        string HashPassword(string password);
        bool PasswordAuthentication(string password, string hashed);
    }
}