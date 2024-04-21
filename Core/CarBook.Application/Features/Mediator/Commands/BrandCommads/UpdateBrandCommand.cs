using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateBrandCommand:IRequest
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
}
