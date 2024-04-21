using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler:IRequestHandler<CreateBrandCommand>
    {
        private readonly IRepository<Brand> _repository;
        private readonly IMapper _mapper;

        public CreateBrandCommandHandler(IRepository<Brand> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(_mapper.Map<Brand>(request));
        }
    }
}
