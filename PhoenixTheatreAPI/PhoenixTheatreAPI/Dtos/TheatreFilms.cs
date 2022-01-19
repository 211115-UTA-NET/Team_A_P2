using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixTheatreAPI.Dtos
{
    public class TheatreFilms
    {
        public int FilmId { get; set; }
        public string FilmName { get; set; }
        public string FilmRating { get; set; }
        public string Genre { get; set; }
        public string FilmDescription { get; set; }
        public int FilmDuration { get; set; }
    }
}
