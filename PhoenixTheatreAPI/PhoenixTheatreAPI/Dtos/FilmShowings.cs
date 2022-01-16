namespace PhoenixTheatreAPI.Dtos
{
    public class FilmShowings
    {
        public string FilmName { get; set; }
        public string FilmRating { get; set; }
        public string Genre { get; set; }
        public string FilmDescription { get; set; }
        public int FilmDuration { get; set; }
        public DateOnly ShowDate { get; set; }
        public TimeOnly ShowTime { get; set; }
        public int TicketsAvailable { get; set; }
    }
}