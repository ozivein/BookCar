namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetBlogWithAuthorQueryResult
    {
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorDescription { get; set; }
    }
}
