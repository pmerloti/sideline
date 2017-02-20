using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    public class Organization
    {
        public Organization()
        {
            Squads = new List<TeamSquad>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LongName { get; set; }
        public string URL { get; set; }
        public string Mascot { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public List<TeamSquad> Squads { get; set; }
    }
}
