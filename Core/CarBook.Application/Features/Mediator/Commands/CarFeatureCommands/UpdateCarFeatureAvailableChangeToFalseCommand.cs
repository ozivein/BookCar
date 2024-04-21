using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateCarFeatureAvailableChangeToFalseCommand : IRequest
    {
        public int CarFeatureId { get; set; }

        public UpdateCarFeatureAvailableChangeToFalseCommand(int carFeatureId)
        {
            CarFeatureId = carFeatureId;
        }
    }
}
