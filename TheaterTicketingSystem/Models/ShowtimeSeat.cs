using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTicketingSystem.Models
{
    public class ShowtimeSeat
    {
        public int ShowtimeSeatID { get; set; }
        public int ShowtimeID { get; set; }
        public int SeatID { get; set; }
        public int StatusID { get; set; } // Available, Reserved, Sold
        //i don't want to put the string SeatNumber because it will not be same in the database and the SeatNumber is in the Seats Table
    }
}
