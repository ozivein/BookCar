using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetBannerByIdQuery:IRequest<GetBannerByIdQueryResult>
    {
        public int BannerId { get; set; }

        public GetBannerByIdQuery(int bannerId)
        {
            BannerId = bannerId;
        }
    }
}
