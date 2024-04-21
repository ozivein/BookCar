using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetFooterAddressByIdQuery:IRequest<GetFooterAddressByIdQueryResult>
    {
        public int FooterAddressId { get; set; }

        public GetFooterAddressByIdQuery(int footerAddressId)
        {
            FooterAddressId = footerAddressId;
        }
    }
}
