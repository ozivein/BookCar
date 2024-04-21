using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetSocialMediaByIdQuery : IRequest<GetSocialMediaByIdQueryResult>
    {
        public int SocialMediaId { get; set; }

        public GetSocialMediaByIdQuery(int socialMediaId)
        {
            SocialMediaId = socialMediaId;
        }
    }
}
