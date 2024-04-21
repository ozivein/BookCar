namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetAuthorByIdQueryResult
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
