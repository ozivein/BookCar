using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetLastThreeBlogsWithAuthorsAndCategoryQueryHandler : IRequestHandler<GetLastThreeBlogsWithAuthorsAndCategoryQuery, List<GetLastThreeBlogsWithAuthorsAndCategoryQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;
        public GetLastThreeBlogsWithAuthorsAndCategoryQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<List<GetLastThreeBlogsWithAuthorsAndCategoryQueryResult>> Handle(GetLastThreeBlogsWithAuthorsAndCategoryQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetLastThreeBlogsWithAuthorsAndCategoryQueryResult>>(await _blogRepository.GetLastThreeBlogsWithAuthorsAndCategoryAsync());
        }
    }
}
