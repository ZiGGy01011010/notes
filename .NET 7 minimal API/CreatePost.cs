using MediatR;
using Domain.Models;

namespace Application.Posts.Commands;

public class CreatePost : IRequest<Post>
{
    public string? PostContent { get; set;}
}