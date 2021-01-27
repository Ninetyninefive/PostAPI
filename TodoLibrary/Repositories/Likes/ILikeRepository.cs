using System.Collections.Generic;
using PostLibrary.Models.Posts;
using PostLibrary.Models.Users;
using PostLibrary.Models.Likes;

namespace PostLibrary.Repositories
{
    public interface ILikeRepository
    {
        Like GetLikesWithId(int id);

        IEnumerable<Like> GetLikedBy(string owner);

        IEnumerable<Like> GetLikes();

        IEnumerable<Like> ShowLikes(int postId);

        Like AddLike(int postId, User user);

        void Update(int postId, User user);

        void ApplyPatch(Like like, Dictionary<string, object> patches);

        void Delete(int postId, User user);
    }
}