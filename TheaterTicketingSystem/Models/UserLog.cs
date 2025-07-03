using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTicketingSystem.Models
{
    internal class UserLog
    {
        public int LogID { get; set; }
        public int UserID { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
