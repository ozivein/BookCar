using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetCommentByBlogIdQuery:IRequest<List<GetCommentByBlogIdQueryResult>>
    {
        public int BlogId { get; set; }

        public GetCommentByBlogIdQuery(int blogId)
        {
            BlogId = blogId;
        }
    }
}
