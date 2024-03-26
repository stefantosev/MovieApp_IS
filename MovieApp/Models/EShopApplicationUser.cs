using Microsoft.AspNetCore.Identity;

namespace MovieApp.Models
{
    public class EShopApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        // product e ticket
        public virtual ICollection<Ticket> MyTickets { get; set; }


    }

}
