using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateAuthorCommand:IRequest
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
