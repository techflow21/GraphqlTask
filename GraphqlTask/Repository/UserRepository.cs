using GraphqlTask.Model;
using System.Xml.Linq;

namespace GraphqlTask.Repository
{
    public class UserRepository
    {
        private readonly List<User> _users = new();

        public IEnumerable<User> GetAll() => _users;

        public User? GetById(string id) => _users.FirstOrDefault(u => u.Id == id);

        public User Add(User user)
        {
            _users.Add(user);
            return user;
        }

        public User? Update(string id, User updatedUser)
        {
            var user = GetById(id);
            if (user is null) return null;

            user.Name = updatedUser.Name ?? user.Name;
            user.Email = updatedUser.Email ?? user.Email;
            user.Phone = updatedUser.Phone ?? user.Phone;
            user.UpdatedAt = DateTime.Now;
            return user;
        }

        public bool Delete(string id)
        {
            var user = GetById(id);
            if (user == null) return false;

            _users.Remove(user);
            return true;
        }
    }

}
