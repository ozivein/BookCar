namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetContactQueryResult
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SenDate { get; set; }
    }
}
