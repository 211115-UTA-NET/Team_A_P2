using System.ComponentModel.DataAnnotations;

namespace PhoenixTheatreAPI.Dtos
{
    public class Theatre
    {
        public int TheatreId { get; set; }
        public string TheatreLocation { get; set; }

        public ICollection<FilmShowings> FilmShowings { get; set;}
    }
}
