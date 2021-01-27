using System;
using System.ComponentModel.DataAnnotations;

namespace PostLibrary.Models.Users
{
    public class User
    {
        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

        public int Id { get; set; }

        public Guid Guid { get; private set; } = Guid.NewGuid();

        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public DateTime RegisterDate { get; private set; } = DateTime.UtcNow;

        

    
    }
}