using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PostLibrary.Models.Users;
using PostLibrary.Models.Posts;

namespace PostLibrary.Models.Likes
{
    public class Like
    {
         public Like(int postId, User user)
        {
            PostId = postId;
            User = user;
            LastDate = LastDate;
        }

        public Guid Guid { get; private set; } = Guid.NewGuid();

        public int PostId { get; set; }

        [Required]
        public User User { get; set; }

        public DateTime LastDate { get; set; } = DateTime.Now;

    }

}