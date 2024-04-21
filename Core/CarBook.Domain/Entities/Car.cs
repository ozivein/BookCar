namespace UdemyCarBook.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; }
        public string BigImageUrl { get; set; }
        public virtual List<CarFeature> CarFeatures { get; set; }
        public virtual List<CarDescription> CarDescriptions { get; set; }
        public virtual List<CarPricing> CarPricings { get; set; }
        public virtual List<RentACar> RentACars { get; set; }
        public virtual List<RentACarProcess> RentACarProcesses { get; set; }
        public virtual List<Reservation> Reservations { get; set; }
        public virtual List<Review> Reviews { get; set; }

    }
}
