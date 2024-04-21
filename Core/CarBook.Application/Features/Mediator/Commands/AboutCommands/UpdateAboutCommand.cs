using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateAboutCommand : IRequest
    {
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
