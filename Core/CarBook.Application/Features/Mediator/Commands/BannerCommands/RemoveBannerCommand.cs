using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveBannerCommand: IRequest
    {
        public int BannerId { get; set; }

        public RemoveBannerCommand(int bannerId)
        {
            BannerId = bannerId;
        }
    }
}
