using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostLibrary.Models.Likes
{
    public class LikeDto
    {
        [Required]
        public int LikeId { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required]
        public int UserId { get; set; }
    }
}
