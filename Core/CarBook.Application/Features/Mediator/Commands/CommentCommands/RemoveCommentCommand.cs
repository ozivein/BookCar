using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveCommentCommand:IRequest
    {
        public int CommentId { get; set; }

        public RemoveCommentCommand(int commentId)
        {
            CommentId = commentId;
        }
    }
}
