using GraphqlTask.Model;
using GraphqlTask.Repository;

namespace GraphqlTask.Type
{
    public class Query
    {
        public IEnumerable<User> GetUsers([Service] UserRepository repository) => repository.GetAll();

        public User? GetUserById(string id, [Service] UserRepository repository) => repository.GetById(id);
    }

}
