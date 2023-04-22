using System.Security.Cryptography;
using System.Text;

namespace Lab6.Services.PasswordHasher
{
    public class PasswordHasher : IPasswordHasher
    {
        public string GeneratePasswordHash(string password)
        {
            using var hmacsha512 = new HMACSHA512();
            var passwordHash = hmacsha512.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(passwordHash);
        }
    }
}
