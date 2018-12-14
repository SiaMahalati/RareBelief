using System.Collections.Generic;

namespace RAREBelief.Domain.Model
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public List<State> States { get; set; }
        public List<Node> Nodes { get; set; }
    }
}
