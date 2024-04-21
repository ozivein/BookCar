using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentBlogCountQueryHandler : IRequestHandler<GetCommentBlogCountQuery, GetCommentBlogCountQueryResult>
    {
        private readonly ICommentRepository _commentRepository;

        public GetCommentBlogCountQueryHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<GetCommentBlogCountQueryResult> Handle(GetCommentBlogCountQuery request, CancellationToken cancellationToken)
        {

            return new GetCommentBlogCountQueryResult { BlogCommentCount = await _commentRepository.BlogCommentCountAsync(request.BlogId) };
        }
    }
}
