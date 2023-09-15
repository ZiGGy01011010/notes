using MediatR;
using MinimalApi.Abstractions;

namespace MinimalApi.EndpointDefinitions;

public class PostEndpointDefinition : IEndpointDefinition
{
    private readonly IMediator _mediator;

    public PostEndpointDefinition(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void RegisterEndpoints(WebApplication app)
    {
        //You can create "base url" for endpoints
        var posts = app.MapGroup("/api/posts");

        posts.MapGet("/{id}", GetPostById);
        
        app.MapPost("/api/posts", CreatePost)
            .AddEndpointFilter<PostValidationFilter>();
        /*
        .
        .
        .
        */
    }

    private async Task<IResult> GetPostById(int id)
    {
        var getPost = new GetPostById { PostId = id };
        var post = await _mediator.Send(getPost);
        return TypedResults.Ok(post);
    }
    private async Task<IResult> CreatePost(Post post)
    {
        var createPost = new CreatePost { PostContent = post.Content };
        var post = await mediator.Send(createPost);
        return Results.CreatedAtRoute("GetPostById", new { post.Id }, post);
    }
}