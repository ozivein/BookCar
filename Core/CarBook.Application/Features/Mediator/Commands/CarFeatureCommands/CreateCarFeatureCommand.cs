using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateCarFeatureCommand:IRequest
    {
        public int CarId { get; set; }
        public int FeatureId { get; set; }
        public bool Available { get; set; }
    }
}
