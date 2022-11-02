﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class UserRegistration
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
