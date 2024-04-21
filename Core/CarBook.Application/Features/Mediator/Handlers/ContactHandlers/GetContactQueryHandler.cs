using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.ContactHandlers
{

    public class GetContactQueryHandler : IRequestHandler<GetContactQuery, List<GetContactQueryResult>>
    {
        private readonly IRepository<Contact> _repository;
        private readonly IMapper _mapper;
        public GetContactQueryHandler(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetContactQueryResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetContactQueryResult>>(await _repository.GetAllAsync());
        }
    }
}
