using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixTheatreAPI.Dtos
{
    public class Tickets
    {
        [Required, Key]
        public string TicketType { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TicketPrice { get; set; }
    }
}