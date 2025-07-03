using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTicketingSystem.Models
{
    public class Showtime
    {
        public int ShowtimeID { get; set; }
        public int MovieID { get; set; }
        public int HallID { get; set; }
        public DateTime ShowtimeDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public decimal Price { get; set; }
    }
}
