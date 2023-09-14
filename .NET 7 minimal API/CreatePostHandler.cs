using MediatR;
using Domain.Models;
using Application.Posts.Commands;

namespace Application.Posts.CommandHandlers

public class CreatePostHandler : IRequestHandler<CreatePost, Post>
{
    private readonly IPostRepository _postRepo;
    public CreatePostHandler(IPostRepository postRepo)
    {
        _postRepo = postRepo;
    }
    public async Task<Post> Handle(CreatePost request, CancellationToken cancellationToken)
    {
        var newPost = new Post
        {
            Content = request.PostContent
        };

        return await _postRepo.CreatePost(newPost);
    }
}