using System.Collections.Generic;
using RareBelief.Infrastructure.Model;

namespace RAREBelief.Domain.Model
{
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
