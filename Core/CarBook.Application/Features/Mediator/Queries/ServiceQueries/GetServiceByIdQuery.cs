using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
    {
        public int ServiceId { get; set; }

        public GetServiceByIdQuery(int serviceId)
        {
            ServiceId = serviceId;
        }
    }
}
