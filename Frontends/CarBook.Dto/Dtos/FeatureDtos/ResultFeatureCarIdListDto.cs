namespace UdemyCarBook.Dto.Dtos
{
    public class ResultFeatureCarIdListDto
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
        public int CarId { get; set; }
        public bool Available { get; set; } = false;
    }
}
