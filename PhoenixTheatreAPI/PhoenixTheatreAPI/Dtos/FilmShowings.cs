using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixTheatreAPI.Dtos
{
    public class FilmShowings
    {
        public int FilmShowingsId { get; set; }
        public int TheatreId { get; set; }
        public int FilmId { get; set; }
        public DateTime ShowDate { get; set; }
        public DateTime ShowTime { get; set; }
        public int TicketsAvailable { get; set; }
        public TheatreFilms TheatreFilms { get; set; }
    }
}