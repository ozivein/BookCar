using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetContactByIdQuery:IRequest<GetContactByIdQueryResult>
    {
        public int ContactId { get; set; }

        public GetContactByIdQuery(int contactId)
        {
            ContactId = contactId;
        }
    }
}
