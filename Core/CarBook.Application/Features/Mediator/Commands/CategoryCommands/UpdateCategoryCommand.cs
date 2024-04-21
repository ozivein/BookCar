using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateCategoryCommand:IRequest
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}
