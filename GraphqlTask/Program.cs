using GraphqlTask.Repository;
using GraphqlTask.Type;

namespace GraphqlTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register GraphQL and services
            builder.Services.AddSingleton<UserRepository>();
            builder.Services.AddGraphQLServer()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseResponseCompression();
            }

            app.UseHttpsRedirection();
            app.MapGraphQL();

            app.Run();
        }
    }
}
