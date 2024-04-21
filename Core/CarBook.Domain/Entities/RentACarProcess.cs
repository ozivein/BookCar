using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class RentACarProcess
    {
        public int RentACarProcessId { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int PicUpLocationId { get; set; }
        public int DropOffLocation { get; set; }
        public DateOnly PicUpDate { get; set; }
        public DateOnly DropOffDate { get; set; }
        public TimeOnly PicUpTime { get; set; }
        public TimeOnly DropOffTime { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string PicUpDescription { get; set; }
        public string DropOffDescription { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
