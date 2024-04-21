namespace UdemyCarBook.Domain.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public virtual List<RentACarProcess> RentACarProcesses { get; set; }
    }
}
