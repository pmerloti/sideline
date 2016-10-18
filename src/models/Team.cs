using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    [DataContract]
    public class Team
    {
        public Team()
        {
            Id = Guid.NewGuid();
        }

        [DataMember]
        public Guid Id { get; private set; }

        [DataMember]
        public string TeamName { get; set; }

        [DataMember]
        public string LongName { get; set; }

        [DataMember]
        public string Gender { get; set; }

        [DataMember]
        public string Mascot { get; set; }

        [DataMember]
        public string Address1 { get; set; }

        [DataMember]
        public string Address2 { get; set; }

        [DataMember]
        public string OverallRecordOverride { get; set; }

    }
}
