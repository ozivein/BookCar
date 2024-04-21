namespace UdemyCarBook.Domain.Entities
{
    public class Review
    {
        public int ReviewId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public string Comment { get; set; }
        public int ReytingValue { get; set; }
        public DateTime CreateDate { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        
    }
}
