using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetAuthorByIdQuery:IRequest<GetAuthorByIdQueryResult>
    {
        public int AuthorId { get; set; }

        public GetAuthorByIdQuery(int authorId)
        {
            AuthorId = authorId;
        }
    }
}
