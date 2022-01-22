using System.ComponentModel.DataAnnotations;

namespace PhoenixTheatreAPI.Dtos
{
    public class CustomerOrder
    {
        [Key]
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public int TheatreId { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
