using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveCategoryCommand:IRequest
    {
        public int CategoryId { get; set; }

        public RemoveCategoryCommand(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
