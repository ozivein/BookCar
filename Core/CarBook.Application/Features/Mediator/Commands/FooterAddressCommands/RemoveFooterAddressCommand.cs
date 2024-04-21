using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class RemoveFooterAddressCommand:IRequest
    {
        public int FooterAddressId { get; set; }

        public RemoveFooterAddressCommand(int footerAddressId)
        {
            FooterAddressId = footerAddressId;
        }
    }
}
