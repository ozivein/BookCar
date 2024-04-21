using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateCategoryCommand:IRequest
    {
        public string Name { get; set; }
    }
}
