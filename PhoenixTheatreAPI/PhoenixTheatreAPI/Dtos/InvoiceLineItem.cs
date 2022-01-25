using System.ComponentModel.DataAnnotations;

namespace PhoenixTheatreAPI.Dtos
{
    public class InvoiceLineItem
    {
        [Key]
        public int InvoiceId { get; }
        public Guid OrderId { get; set; }
        public string TicketType { get; set; }
        public int Quantity { get; set; }
    }
}