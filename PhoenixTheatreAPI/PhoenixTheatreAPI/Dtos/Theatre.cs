namespace PhoenixTheatreAPI.Dtos
{
    public class Theatre
    {
        public int TheatreId { get; set; }
        public string TheatreLocation { get; set; }
        public FilmShowings FilmShowings { get; set; }
        public Tickets Tickets { get; set; }
    }
}
