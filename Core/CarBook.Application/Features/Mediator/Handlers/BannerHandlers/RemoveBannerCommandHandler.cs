using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BannerHandlers
{
    public class RemoveBannerCommandHandler:IRequestHandler<RemoveBannerCommand>
    {
        private readonly IRepository<Banner> _repository;
        private readonly IMapper _mapper;

        public RemoveBannerCommandHandler(IRepository<Banner> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(RemoveBannerCommand request, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(await _repository.GetByIdAsync(request.BannerId));
        }
    }
}
