namespace UdemyCarBook.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public virtual Car Card { get; set; }

        public int FeatureId { get; set; }
        public virtual Feature Feature { get; set; }

        public bool Available { get; set; }

    }
}
