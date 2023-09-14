using MediatR;
using Domain.Models;

namespace Application.Posts.Queries

public class GetAllPosts : IRequest<ICollection<Post>>
{
}