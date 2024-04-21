using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveBrandCommand:IRequest
    {
        public int BrandId { get; set; }

        public RemoveBrandCommand(int brandId)
        {
            BrandId = brandId;
        }
    }
}
