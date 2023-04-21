using Lab6.Models;
using Lab6.Services.PasswordHasher;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Lab6.Services.UserData
{
    public class UserData : IUserData
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly List<User> _users = new List<User>
        {
            new("1", "John", "Doe", "johndoe@gmail.com", "12345", DateTime.Now, 0),
            new("2", "Jane", "Doe", "janedoe@gmail.com", "password456", DateTime.Now, 0),
            new("3", "Bob", "Smith", "bobsmith@gmail.com", "password789", DateTime.Now, 0),
            new("4", "Alice", "Johnson", "alicejohnson@gmail.com", "password123", DateTime.Now, 0),
            new("5", "Jack", "Brown", "jackbrown@gmail.com", "password456", DateTime.Now, 0)
        };

        public UserData(IPasswordHasher passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public async Task<UserDto> Login(UserDto userDto)
        {
            var user = _users.FirstOrDefault(u => u.Email == userDto.Email && u.Password == userDto.Password);
            if (user == null)
            {
                throw new NullReferenceException("There is no user with these credits");
            }

            var token = GenerateJwtToken(user);
            return MapUserToDto(user, token);
        }

        public async Task<UserDto> Register(UserDto userDto)
        {
            if (_users.Any(u => u.Email == userDto.Email))
                throw new ApplicationException("Email \"" + userDto.Email + "\" is already taken");

            var user = MapDtoToUser(userDto);
            user.Id = Guid.NewGuid().ToString();
            user.Password = _passwordHasher.GeneratePasswordHash(userDto.Password);
            _users.Add(user);

            var token = GenerateJwtToken(user);
            return MapUserToDto(user, token);
        }

        private static string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("IssuerSigningKey");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private static UserDto MapUserToDto(User user, string token = null)
        {
            return new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Token = token
            };
        }

        private static User MapDtoToUser(UserDto userDto)
        {
            return new User
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email
            };
        }
    }
}
