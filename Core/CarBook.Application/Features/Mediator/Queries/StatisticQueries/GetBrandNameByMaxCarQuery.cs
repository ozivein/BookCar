using MediatR;
using UdemyCarBook.Application.Features.Mediator.Results;

namespace UdemyCarBook.Application.Features.Mediator.Queries
{
    public class GetBrandNameByMaxCarQuery:IRequest<GetBrandNameByMaxCarQueryResult>
    {
    }
}
