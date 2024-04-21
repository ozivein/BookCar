namespace UdemyCarBook.Domain.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }

        public virtual List<CarFeature> CarFeatures { get; set; }
    }
}
