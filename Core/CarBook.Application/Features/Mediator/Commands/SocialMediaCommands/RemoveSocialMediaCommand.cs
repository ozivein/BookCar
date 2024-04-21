using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveSocialMediaCommand:IRequest
    {
        public int SocialMediaId { get; set; }

        public RemoveSocialMediaCommand(int socialMediaId)
        {
            SocialMediaId = socialMediaId;
        }
    }
}
