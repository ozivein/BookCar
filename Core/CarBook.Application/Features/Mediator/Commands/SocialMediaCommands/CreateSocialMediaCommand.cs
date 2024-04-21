using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateSocialMediaCommand:IRequest
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}
