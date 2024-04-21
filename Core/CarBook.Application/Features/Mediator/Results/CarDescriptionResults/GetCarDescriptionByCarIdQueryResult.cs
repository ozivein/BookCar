using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetCarDescriptionByCarIdQueryResult
    {
        public int CarDescriptionId { get; set; }
        public int CarId { get; set; }
        public string Detail { get; set; }
    }
}
