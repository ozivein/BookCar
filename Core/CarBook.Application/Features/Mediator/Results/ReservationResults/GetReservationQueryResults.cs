namespace UdemyCarBook.Application.Features.Mediator.Results
{
    public class GetReservationQueryResults
    {
        public int ReservationId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public int PickUpLocationId { get; set; }
        public string PickUpLocationName { get; set; }
        public int DropOffLocationId { get; set; }
        public string DropOffLocationName { get; set; }
        public int Age { get; set; }
        public int DriverLicenseYear { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

    }
}
