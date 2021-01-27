using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PostLibrary.Models.Users;
using PostLibrary.Models.Posts;
using PostLibrary.Models.Likes;


namespace PostLibrary.Models.Posts
{
    public class Post
    {
        private const string _rangeMessage = "{0} must be between {1} and {2}";
        private const string _stringMessage = "{0} must be between {2} and {1} characters long";

        public Post(int id)
        {
            Id = id;
        }

        public Post(int id, PostDto postDto, User user)
        {
            Id = id;
            LastDate = postDto.LastDate;
            Content = postDto.Content;
            CreatedBy = user;
        }

        public int Id { get; private set; }

        public Guid Guid { get; private set; } = Guid.NewGuid();

        [Required]
        [StringLength(400, ErrorMessage = _stringMessage, MinimumLength = 1)]
        public string Content { get; set; }

        [Required]
        public User CreatedBy { get; set; }

        [Range(typeof(DateTime), "1/1/2020", "1/1/2022", ErrorMessage = _rangeMessage)]
        public DateTime LastDate { get; set; } = DateTime.Now;

        [Required]
        public bool Hidden { get; set; }

        public List<Like> LikedBy { get; set; } = new List<Like>();


    }
   
}