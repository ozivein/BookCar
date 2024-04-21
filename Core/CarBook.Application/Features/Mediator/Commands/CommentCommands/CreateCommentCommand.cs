using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateCommentCommand:IRequest
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
    }
}
