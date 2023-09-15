namespace MinimalApi.Extensions;

public static class MinimalApiExtensions
{
    //You can group services (for clarity) in private methods and use them here.
    //For example: RegisterRepositories, RegisterUtilities etc.
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        var cs = builder.Configuration.GetConnectionString("Default");
        builder.Services.AddDbContext<SocialDbContext>(opt => opt.UseSqlServer(cs));
        builder.Services.AddScoped<IPostRepository, PostRepository>();
        builder.Services.AddMediatR(typeof(CreatePost));
    }

    //Little bit of reflection
    public static void RegisterEndpointDefinitions(this WebApplication app)
    {
        typeof(Program).Assembly
        .GetTypes()
        .Where(t => t.IsAssignableTo(typeof(IEndpointDefinition))
            && !t.IsAbstract && !t.IsInterface)
        .Select(Activator.CreateInstance)
        .Cast<IEndpointDefinition>()
        .ForEach(e => e.RegisterEndpoints(app));
    }
}