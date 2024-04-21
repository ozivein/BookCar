using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetFooterAddressByIdQueryResult:IRequest
    {
        public int FooterAddressId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}
