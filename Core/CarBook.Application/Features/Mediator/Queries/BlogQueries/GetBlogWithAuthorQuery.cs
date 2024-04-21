using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetBlogWithAuthorQuery:IRequest<GetBlogWithAuthorQueryResult>
    {
        public int BlodId { get; set; }

        public GetBlogWithAuthorQuery(int blodId)
        {
            BlodId = blodId;
        }
    }
}
