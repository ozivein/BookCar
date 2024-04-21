using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateCarFeatureAvailableChangeToTrueCommand:IRequest
    {
        public int CarFeatureId { get; set; }

        public UpdateCarFeatureAvailableChangeToTrueCommand(int carFeatureId)
        {
            CarFeatureId = carFeatureId;
        }
    }
}
