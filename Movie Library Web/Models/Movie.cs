using System.Collections.Generic;
namespace Movie_Library_Web.Models
{
    public class Movie
    {
        public Movie()
        {

        }

        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string GenreName { get; set; }
        public string Rating { get; set; }
        public string RatingScale { get; set; }
        public string SeriesOrMovie { get; set; }
    }
}
