using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetCommentByIdQuery:IRequest<GetCommentByIdQueryResult>
    {
        public int CommentId { get; set; }

        public GetCommentByIdQuery(int commentId)
        {
            CommentId = commentId;
        }
    }
}
