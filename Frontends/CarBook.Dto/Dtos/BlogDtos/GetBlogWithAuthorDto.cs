namespace UdemyCarBook.Dto.Dtos
{
    public class GetBlogWithAuthorDto
    {
        public int BlogId { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        public string AuthorDescription { get; set; }
    }
}
