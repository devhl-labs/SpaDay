using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SpaDay.Models;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {
        [Required]
        [StringLength(15, MinimumLength = 5, ErrorMessage ="User name must be 5 to 15 characters.")]
        public string UserName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Valid passwords are 6 to 20 characters.")]
        [Compare(nameof(VerifyPassword), ErrorMessage = "Passwords do not match.")]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required]
        public string VerifyPassword { get; set; }

        public User ToUser()
        {
            return new User(UserName, Password, Email);
        }
    }
}
