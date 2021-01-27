using System;

namespace PostLibrary.Models.Posts
{
    public class PostQueryDto
    {
        public bool? Hidden { get; set; }

        public string CreatedBy { get; set; }

        public bool IsEmpty => Hidden is null && CreatedBy is null;

    }
}