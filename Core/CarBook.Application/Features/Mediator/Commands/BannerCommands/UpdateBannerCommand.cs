using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateBannerCommand: IRequest
    {
        public int BannerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string VideoDescription { get; set; }
        public string VideoUrl { get; set; }
    }
}
