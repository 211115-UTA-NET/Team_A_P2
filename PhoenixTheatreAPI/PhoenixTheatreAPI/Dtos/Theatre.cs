namespace PhoenixTheatreAPI.Dtos
{
    public class Theatre
    {
        public int TheatreId { get; set; }
        public string TheatreLocation { get; set; }
        public FilmShowings filmShowings { get; set; }
        public Tickets tickets { get; set; }
    }
}
