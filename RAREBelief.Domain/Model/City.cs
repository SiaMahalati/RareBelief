using System.Collections.Generic;
using RareBelief.Infrastructure.Model;

namespace RAREBelief.Domain.Model
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public int StateId { get; set; }
        public State State { get; set; }
        public List<Node> Nodes { get; set; } 
    }
}
