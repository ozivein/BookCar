using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetBrandByIdQuery:IRequest<GetBrandByIdQueryResult>
    {
        public int BrandId { get; set; }

        public GetBrandByIdQuery(int brandId)
        {
            BrandId = brandId;
        }
    }
}
