namespace UdemyCarBook.Domain.Entities
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }

        public virtual List<Car> Cars { get; set; }
    }
}
