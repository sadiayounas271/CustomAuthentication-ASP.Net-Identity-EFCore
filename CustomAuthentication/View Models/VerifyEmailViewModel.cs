using System.ComponentModel.DataAnnotations;

namespace CustomAuthentication.View_Models
{
    public class VerifyEmailViewModel
    {
        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
