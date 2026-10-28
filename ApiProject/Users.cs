using System.ComponentModel.DataAnnotations;

namespace ApiProject
{
    //This class holds one user, so User is a clearer name than Users.
    //A full name is clearer than an abbreviation: Password instead of Pass.
    //If you rename it, user.txt still has the old name, so read it with
    //new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
    public class Users
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Pass { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public int UserId { get; set; }
    }
}
