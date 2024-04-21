using MediatR;

namespace UdemyCarBook.Application.Features.Mediator.Commands.ReviewCommands
{
    public class CreateReviewCommand:IRequest
    {
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string Comment { get; set; }
        public int ReytingValue { get; set; }
        public DateTime CreateDate { get; set; }
        public int CarId { get; set; }
    }
}
