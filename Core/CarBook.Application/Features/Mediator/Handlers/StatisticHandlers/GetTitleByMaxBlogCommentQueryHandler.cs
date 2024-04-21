using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetTitleByMaxBlogCommentQueryHandler : IRequestHandler<GetTitleByMaxBlogCommentQuery, GetTitleByMaxBlogCommentQueryResult>
    {
        private readonly IStatisticRepository _statisticRepository;

        public GetTitleByMaxBlogCommentQueryHandler(IStatisticRepository statisticRepository)
        {
            _statisticRepository = statisticRepository;
        }

        public async Task<GetTitleByMaxBlogCommentQueryResult> Handle(GetTitleByMaxBlogCommentQuery request, CancellationToken cancellationToken)
        {
            return new GetTitleByMaxBlogCommentQueryResult { BlogTitle = await _statisticRepository.GetTitleByMaxBlogComment() };
        }
    }
}
