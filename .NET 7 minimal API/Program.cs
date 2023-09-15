using MinimalApi.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices();

var app = builder.Build();
// Basic custom middleware for exceptions handling
// Put at beginning of pipeline
app.Use(async (ctx, next) =>
{
    try
    {
        await next();
    }
    catch (Exception)
    {
        ctx.Response.StatusCode = 500;
        await ctx.Response.WriteAsync("An error ocurred");
    }
});

app.UseHttpsRedirection();

app.RegisterEndpointDefinitions();

app.Run();