using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTicketingSystem.Models
{
    public class Hall
    {
        public int HallID { get; set; }
        public string HallName { get; set; }
        public int Capacity { get; set; }

        public override string ToString()
        {
            return HallName;
        }
    }
}
