using Microsoft.AspNetCore.Identity;

namespace Drag_Drop.Data
{
    public class Client:IdentityUser
    {
        public int Id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime RegisterOn { get; set; } = DateTime.Now;
        public ICollection<Order> Orders { get; set; }

    }
}
