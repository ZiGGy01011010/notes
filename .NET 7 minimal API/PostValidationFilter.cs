namespace MinimalApi.Filters;

public class PostValidationFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        //This part i don't like, we get parameters by index
        if (string.IsNullOrEmpty(context.GetArgument<Post>(1).Content))
            return await Task.FromResult(Results.BadRequest("Post not valid"));
        
        return await next(context);
    }
}