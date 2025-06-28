using GraphqlTask.DTO;

namespace GraphqlTask.Validations
{
    public static class UserValidator
    {
        public static void Validate(UserDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Name) || dto.Name.Length < 3)
                throw new GraphQLException(ErrorBuilder.New()
                    .SetMessage("Name must be at least 3 characters long.")
                    .Build());

            if (!System.Text.RegularExpressions.Regex.IsMatch(dto.Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new GraphQLException(ErrorBuilder.New()
                    .SetMessage("Invalid email format.")
                    .Build());

            if (!System.Text.RegularExpressions.Regex.IsMatch(dto.Phone, @"^\+?[0-9]{7,15}$"))
                throw new GraphQLException(ErrorBuilder.New()
                    .SetMessage("Phone number must be valid and contain only digits, may start with +.")
                    .Build());
        }
    }

}
