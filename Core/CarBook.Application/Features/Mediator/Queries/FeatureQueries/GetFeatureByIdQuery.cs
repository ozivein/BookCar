using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetFeatureByIdQuery:IRequest<GetFeatureByIdQueryResult>
    {
        public int FeatureId {  get; set; }

        public GetFeatureByIdQuery(int featureId)
        {
            FeatureId = featureId;
        }
    }
}
