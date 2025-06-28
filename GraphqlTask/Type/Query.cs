using GraphqlTask.Model;
using GraphqlTask.Repository;

namespace GraphqlTask.Type
{
    public class Query
    {
        [UseProjection]
        public IEnumerable<User> GetUsers([Service] UserRepository repository) => repository.GetAll();

        [UseProjection]
        public User? GetUserById(string id, [Service] UserRepository repository) => repository.GetById(id);
    }

}
