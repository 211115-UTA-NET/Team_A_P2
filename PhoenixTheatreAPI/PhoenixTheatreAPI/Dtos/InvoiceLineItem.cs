namespace PhoenixTheatreAPI.Dtos
{
    public class InvoiceLineItem
    {
        public int InvoiceId { get; set; }
        public Tickets Tickets { get; set; }
        public int Quantity { get; set; }
    }
}