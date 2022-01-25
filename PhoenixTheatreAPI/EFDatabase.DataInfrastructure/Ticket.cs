using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class Ticket
    {
        public Ticket()
        {
            InvoiceLineItems = new HashSet<InvoiceLineItem>();
        }
        [Key]
        public string TicketType { get; set; } = null!;
        public decimal TicketPrice { get; set; }

        public virtual ICollection<InvoiceLineItem> InvoiceLineItems { get; set; }
    }
}
