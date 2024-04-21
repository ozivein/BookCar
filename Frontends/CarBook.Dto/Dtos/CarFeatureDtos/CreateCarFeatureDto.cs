namespace UdemyCarBook.Dto.Dtos
{
    public class CreateCarFeatureDto
    {
        public int CarId { get; set; }
        public int FeatureId { get; set; }
        public bool Available { get; set; }
    }
}
