using Microsoft.AspNet.Identity.EntityFramework;

namespace RAREBelief.Domain.Model
{
    public class User : IdentityUser
    {
        public int? NodeId { get; set; }
        public Node Node { get; set; }
    }
}
