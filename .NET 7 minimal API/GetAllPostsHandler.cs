using MediatR;
using Domain.Models;
using Application.Posts.Queries;

namespace Application.Posts.QueryHandlers

public class GetAllPostsHandler : IRequestHandler<GetAllPosts, ICollection<Post>>
{
    private readonly IPostRepository _postRepo;
    public GetAllPostsHandler(IPostRepository postRepo)
    {
        _postRepo = postRepo;
    }
    public async Task<ICollection<Post>> Handle(GetAllPosts request, CancellationToken cancellationToken)
    {
        return await _postRepo.GetAllPosts();
    }
}