using AutoMapper;
using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries;
using UdemyCarBook.Application.Features.Mediator.Results;
using UdemyCarBook.Application.Interfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.AppUserHandlers
{
    public class GetCheckApUserQueryHandler : IRequestHandler<GetCheckApUserQuery, GetCheckApUserQueryResult>
    {
        private readonly IAppUserRepository _appUserRepository;
        private readonly IMapper _mapper;

        public GetCheckApUserQueryHandler(IAppUserRepository appUserRepository, IMapper mapper)
        {
            _appUserRepository = appUserRepository;
            _mapper = mapper;
        }

        public async Task<GetCheckApUserQueryResult> Handle(GetCheckApUserQuery request, CancellationToken cancellationToken)
        {
            var value = _mapper.Map<GetCheckApUserQueryResult>(await _appUserRepository.GetCheckAppUserAndRoleAsync(x => x.AppUserName == request.UserName && x.Password == request.Password));
            if (value.AppUserName is null)
            {
                value.IsExist = false;
            }
            else
            {
                value.IsExist = true;
            }
            return value;
        }
    }
}
