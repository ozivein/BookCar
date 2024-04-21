namespace UdemyCarBook.Dto.Dtos
{
    public class ResultRentAcarLocationFilterDto
    {
        public int LocationId { get; set; }
        public DateOnly PicUpDate { get; set; }
        public DateOnly BackOffDate { get; set; }
        public TimeOnly PicUpTime { get; set; }
        public TimeOnly BackOffTime { get; set; }
    }
}
