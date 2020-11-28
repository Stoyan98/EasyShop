using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace EasyShop.Domain.Models
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Username is required.")]
        [StringLength(60, ErrorMessage = "Username cannot be more than 60 characters.")]
        public string Nickname { get; set; }

        public DateTime CreatedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
