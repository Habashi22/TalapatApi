﻿using System.ComponentModel.DataAnnotations;

namespace TalapatApis.DTOS
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
