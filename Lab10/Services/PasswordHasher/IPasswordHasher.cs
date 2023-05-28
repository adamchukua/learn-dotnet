namespace Lab6.Services.PasswordHasher
{
    public interface IPasswordHasher
    {
        string GeneratePasswordHash(string password);
    }
}
