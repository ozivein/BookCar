namespace UdemyCarBook.Domain.Entities
{
    public class RentACar
    {
        public int RentACarId { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public bool Available { get; set; }
    }
}
