using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class GetReviewListByCarIdQueryHandler : IRequestHandler<GetReviewListByCarIdQuery, List<GetReviewListByCarIdQueryResult>>
    {
        private readonly IMapper _mapper;
        private readonly IReviewRepository _reviewRepository;
        public GetReviewListByCarIdQueryHandler(IMapper mapper, IReviewRepository reviewRepository)
        {
            _mapper = mapper;
            _reviewRepository = reviewRepository;
        }

        public async Task<List<GetReviewListByCarIdQueryResult>> Handle(GetReviewListByCarIdQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetReviewListByCarIdQueryResult>>(await _reviewRepository.GetReviewListByCarIdAsync(request.CarId));
        }
    }
}
