using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterTicketingSystem.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; } // in minutes
        public string Language { get; set; }
        public string PosterPath { get; set; }
        public bool IsActive { get; set; }
        public string AgeRating { get; set; }

        public override string ToString()
        {
            return Title;
        }

    }
}
