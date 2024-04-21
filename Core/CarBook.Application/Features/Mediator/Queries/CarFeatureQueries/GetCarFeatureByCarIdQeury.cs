using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetCarFeatureByCarIdQeury:IRequest<List<GetCarFeatureByCarIdQeuryResult>>
    {
        public int CarId { get; set; }

        public GetCarFeatureByCarIdQeury(int carId)
        {
            CarId = carId;
        }
    }
}
