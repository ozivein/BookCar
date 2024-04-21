namespace UdemyCarBook.Domain.Entities
{
    public class CarDescription
    {
        public int CarDescriptionId { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public string Detail { get; set; }


    }
}
