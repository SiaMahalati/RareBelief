using System.Collections.Generic;

namespace RAREBelief.Domain.Model
{
    //Node can be any participating organization anywhere in the world
    public class Node : BaseEntity
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public List<Country> Countries { get; set; }
        public List<State> States { get; set; }
        public int ParentNodeId { get; set; }
        public List<Node> Nodes { get; set; }
        public List<User> Users { get; set; }
    }
}
