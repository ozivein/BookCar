using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateCommentCommand:IRequest
    {
        public int CommentId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
    }
}
