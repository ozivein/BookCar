using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetBlogByIdQuery:IRequest<GetBlogByIdQueryResult>
    {
        public int BlogId { get; set; }

        public GetBlogByIdQuery(int blogId)
        {
            BlogId = blogId;
        }
    }
}
