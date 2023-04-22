using System.ComponentModel.DataAnnotations;

namespace Lab6.Models
{
    public class User
    {
        public string Id { get; set; }
        [StringLength(15)]
        public string FirstName { get; set; }
        [StringLength(15)]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateTimeLastAuthorized { get; set; }
        public int FailedAuthorizations { get; set; }

        public User() {}

        public User(string id, string firstName, string lastName, string email, string password, DateTime dateTimeLastAuthorized, int failedAuthorizations)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            DateTimeLastAuthorized = dateTimeLastAuthorized;
            FailedAuthorizations = failedAuthorizations;
        }
    }
}
