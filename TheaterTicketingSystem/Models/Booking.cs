using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTicketingSystem.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public int UserID { get; set; }
        public int ShowtimeID { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; } // Paid, Reserved, Cancelled
    }
}
