using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTicketingSystem.Models
{
    public class BookingDetail
    {
        public int BookingDetailID { get; set; }
        public int BookingID { get; set; }
        public int SeatID { get; set; }
        public decimal Price { get; set; }
    }
}
