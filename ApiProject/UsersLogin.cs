using System.ComponentModel.DataAnnotations;

namespace ApiProject
{
    //A clearer name is, for example, LoginUser (it holds one user's login details), and Password instead of Pass
    public class UsersLogin
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Pass { get; set; }
        
    }
}
