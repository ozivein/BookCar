namespace UdemyCarBook.Dto.Dtos
{
    public class CreateCommentDto
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
        public string DataProtectBlogId { get; set; }
    }
}
