using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class TheatreFilm
    {
        public TheatreFilm()
        {
            FilmShowings = new HashSet<FilmShowing>();
        }
        [Key]
        public int FilmId { get; set; }
        public string FilmName { get; set; } = null!;
        public string FilmRating { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string FilmDescription { get; set; } = null!;
        public int FilmDuration { get; set; }

        public virtual ICollection<FilmShowing> FilmShowings { get; set; }
    }
}
