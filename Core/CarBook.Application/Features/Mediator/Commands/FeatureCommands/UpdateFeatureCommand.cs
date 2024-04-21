using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateFeatureCommand:IRequest
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
