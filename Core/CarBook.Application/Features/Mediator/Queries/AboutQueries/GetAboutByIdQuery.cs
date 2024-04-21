using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetAboutByIdQuery : IRequest<GetAboutByIdQueryResult>
    {
        public int AboutId { get; set; }

        public GetAboutByIdQuery(int aboutId)
        {
            AboutId = aboutId;
        }
    }
}
