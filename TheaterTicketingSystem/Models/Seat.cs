using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTicketingSystem.Models
{
    public class Seat
    {
        public int SeatID { get; set; }
        public int HallID { get; set; }
        public string SeatNumber { get; set; }
    }
}
