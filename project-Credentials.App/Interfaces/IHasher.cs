namespace project_Credentials.App.Interfaces
{
    public interface IHasher
    {
        string HashPassword(string password);
        bool PasswordAuthentication(string password, string hashed);
    }
}