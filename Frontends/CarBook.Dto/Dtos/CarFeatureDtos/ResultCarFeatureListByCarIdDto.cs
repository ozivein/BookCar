namespace UdemyCarBook.Dto.Dtos
{
    public class ResultCarFeatureListByCarIdDto
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public bool Available { get; set; }
        public string DataProtect { get; set; }
    }
}
