using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands
{
    public class UpdateContactCommand:IRequest
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SenDate { get; set; }
    }
}
