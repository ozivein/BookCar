using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Enums;
using UdemyCarBook.Application.Features.Mediator.Commands;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
    {
        private readonly IRepository<AppUser> _appUserRepository;
        private readonly IMapper _mapper;
        public CreateAppUserCommandHandler(IRepository<AppUser> appUserRepository, IMapper mapper)
        {
            _appUserRepository = appUserRepository;
            _mapper = mapper;
        }

        public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
        {
            request.AppRoleId = (int)RoleType.Member;

            await _appUserRepository.CreateAsync(_mapper.Map<AppUser>(request));
        }
    }
}
