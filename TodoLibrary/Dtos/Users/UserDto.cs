using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostLibrary.Models.Users
{
    public class UserDto
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}