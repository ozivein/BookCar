using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveAuthorCommand:IRequest
    {
        public int AuthorId { get; set; }

        public RemoveAuthorCommand(int authorId)
        {
            AuthorId = authorId;
        }
    }
}
