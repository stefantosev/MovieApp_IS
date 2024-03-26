﻿using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public double Price { get; set; }
        public Guid MovieId { get; set; }
        public Movie? Movie { get; set; }
        public virtual EShopApplicationUser? CreatedBy { get; set; }
        public virtual ICollection<TicketInShoppingCart>? TicketsInShoppingCart { get; set; }
        public ICollection<TicketInOrder>? TicketInOrders { get; set; }

    }
}
