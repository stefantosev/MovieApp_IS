﻿using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class TicketInOrder
    {

        [Key]
        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
        public Ticket? OrderedTicket { get; set; }

        public Guid OrderId { get; set; }
        public Order? Order { get; set; }
        public int Quantity { get; set; }

        // ticket e product

    }
}
