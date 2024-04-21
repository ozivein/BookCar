using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetTagCloudByBlogIdQuery : IRequest<List<GetTagCloudByBlogIdQueryResult>>
    {
        public int BlodId { get; set; }

        public GetTagCloudByBlogIdQuery(int blodId)
        {
            BlodId = blodId;
        }
    }
}
