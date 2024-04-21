namespace UdemyCarBook.Dto.Dtos
{
    public class ResultContactDto
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime SenDate { get; set; }
        public string DataProtect { get; set; }
    }
}
