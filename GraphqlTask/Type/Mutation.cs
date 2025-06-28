using GraphqlTask.DTO;
using GraphqlTask.Model;
using GraphqlTask.Repository;
using GraphqlTask.Validations;

namespace GraphqlTask.Type
{
    public class Mutation
    {
        public User AddUser(UserDto dto, [Service] UserRepository repository)
        {
            UserValidator.Validate(dto);

            var user = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Phone = dto.Phone,
                CreatedAt = DateTime.Now
            };

            return repository.Add(user);
        }

        public User? UpdateUser(string id, UserDto dto, [Service] UserRepository repository)
        {
            UserValidator.Validate(dto);

            var updatedUser = new User
            {
                Name = dto.Name,
                Email = dto.Email,
                Phone = dto.Phone,
                UpdatedAt = DateTime.Now
            };

            return repository.Update(id, updatedUser);
        }

        public string DeleteUser(string id, [Service] UserRepository repository)
        {
            var success = repository.Delete(id);
            return success ? "User deleted successfully." : "User not found.";
        }

    }

}
