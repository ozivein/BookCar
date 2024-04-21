using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries.CarDescrpitonQueries
{
    public class GetCarDescriptionByCarIdQuery:IRequest<GetCarDescriptionByCarIdQueryResult>
    {
        public int CarId { get; set; }

        public GetCarDescriptionByCarIdQuery(int carId)
        {
            CarId = carId;
        }
    }
}
