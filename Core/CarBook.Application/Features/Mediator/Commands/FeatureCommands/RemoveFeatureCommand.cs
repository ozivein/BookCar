using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveFeatureCommand:IRequest
    {
        public int FeatureId { get; set; }

        public RemoveFeatureCommand(int featureId)
        {
            FeatureId = featureId;
        }
    }
}
