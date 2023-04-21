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
    }
}
