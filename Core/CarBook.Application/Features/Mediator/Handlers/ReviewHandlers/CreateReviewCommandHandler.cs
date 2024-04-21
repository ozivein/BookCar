using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Review> _repository;

        public CreateReviewCommandHandler(IMapper mapper, IRepository<Review> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {
           await _repository.CreateAsync(_mapper.Map<Review>(request));
        }
    }
}
