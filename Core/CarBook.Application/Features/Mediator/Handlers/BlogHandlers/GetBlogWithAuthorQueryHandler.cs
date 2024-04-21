using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers
{
    public class GetBlogWithAuthorQueryHandler : IRequestHandler<GetBlogWithAuthorQuery, GetBlogWithAuthorQueryResult>
    {
        private readonly IMapper _mapper;
        private readonly IBlogRepository _blogRepository;

        public GetBlogWithAuthorQueryHandler(IMapper mapper, IBlogRepository blogRepository)
        {
            _mapper = mapper;
            _blogRepository = blogRepository;
        }

        public async Task<GetBlogWithAuthorQueryResult> Handle(GetBlogWithAuthorQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<GetBlogWithAuthorQueryResult>(await _blogRepository.GetBlogWithAuthorListAsync());
        }
    }
}
