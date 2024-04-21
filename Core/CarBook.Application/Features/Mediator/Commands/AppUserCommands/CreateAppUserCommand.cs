using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class CreateAppUserCommand : IRequest
    {
        public string AppUserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int AppRoleId { get; set; }
    }
}
