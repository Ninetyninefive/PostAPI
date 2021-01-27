using System.Collections.Generic;
using PostLibrary.Models.Posts;
using PostLibrary.Models.Users;

namespace PostLibrary.Repositories
{
    public interface IUserRepository
    {
        User GetUserWithId(int id);

        IEnumerable<User> GetUsers();

        IEnumerable<User> GetUserByEmail(string email);
        IEnumerable<User> GetUserByName(string name);

        User Add(UserDto userDto);

        void Update(User user);

        void ApplyPatch(User user, Dictionary<string, object> patches);

        void Delete(User user);
    }
}