﻿using System.ComponentModel.DataAnnotations;

namespace CustomAuthentication.View_Models
{
    public class LoginViewModel
    {
            [Required(ErrorMessage = "Email is Required")]
            [EmailAddress]
            public string Email { get; set; }

            [Required(ErrorMessage = "Password is Required")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember Me?")]
            public bool RememberMe { get; set; }
    }
}
