using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveBlogCommand:IRequest
    {
        public int BlogId { get; set; }

        public RemoveBlogCommand(int blogId)
        {
            BlogId = blogId;
        }
    }
}
