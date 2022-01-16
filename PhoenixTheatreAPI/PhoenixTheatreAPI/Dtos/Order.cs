namespace PhoenixTheatreAPI.Dtos
{
    public class Order
    {
        public Guid OderId { get; set; }
        public Guid CustomerId { get; set; }
        public int TheatreId { get; set; }
        public decimal TotalPrice { get; set; }
        public InvoiceLineItem InvoiceLineItem { get; set; }
    }
}
