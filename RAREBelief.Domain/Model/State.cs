using System.Collections.Generic;

namespace RAREBelief.Domain.Model
{
    public class State : BaseEntity
    {
        public string Name { get; set; }
        public List<City> Cities { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public List<Node> Nodes { get; set; }
    }
}
