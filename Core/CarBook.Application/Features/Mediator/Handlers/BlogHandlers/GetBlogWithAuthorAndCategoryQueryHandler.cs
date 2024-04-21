using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithAuthorAndCategoryQueryHandler : IRequestHandler<GetBlogWithAuthorAndCategoryQuery, List<GetBlogWithAuthorAndCategoryQueryResult>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogWithAuthorAndCategoryQueryHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<List<GetBlogWithAuthorAndCategoryQueryResult>> Handle(GetBlogWithAuthorAndCategoryQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetBlogWithAuthorAndCategoryQueryResult>>(await _blogRepository.GetBlogWithAuthorAndCategoryListAsync());
        }
    }
}
