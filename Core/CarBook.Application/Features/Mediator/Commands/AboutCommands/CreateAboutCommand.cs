using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateAboutCommand : IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

    }
}
