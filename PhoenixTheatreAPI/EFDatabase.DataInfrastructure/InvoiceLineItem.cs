﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PhoenixTheatre.DataInfrastructure
{
    public partial class InvoiceLineItem
    {
        [Key]
        public int InvoiceId { get; set; }
        public Guid? OrderId { get; set; }
        public string? TicketType { get; set; }
        public int Quantity { get; set; }

        public virtual CustomerOrder? Order { get; set; }
        public virtual Ticket? TicketTypeNavigation { get; set; }
    }
}
