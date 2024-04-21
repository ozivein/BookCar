using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarPricingHandlers
{
    public class CreateCarPricingCommandHandler : IRequestHandler<CreateCarPricingCommand>
    {
        private readonly IRepository<CarPricing> _repository;
        private readonly IMapper _mapper;
        public CreateCarPricingCommandHandler(IRepository<CarPricing> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Handle(CreateCarPricingCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(_mapper.Map<CarPricing>(request));
        }
    }
}
