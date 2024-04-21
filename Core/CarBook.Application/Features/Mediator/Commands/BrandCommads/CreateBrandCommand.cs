using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateBrandCommand:IRequest
    {
        public string Name { get; set; }
    }
}
