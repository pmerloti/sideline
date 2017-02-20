using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    public class TeamSquad
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string HeadCoach { get; set; }
        public string AssistantCoach { get; set; }
        public DateTime Since { get; set; }
        public string Season { get; set; }
        //i.e.: Seniors & Juniors, 14U, etc
        public string AgeBracket { get; set; }
        public string Colors { get; set; }
        public string TeamPicturePath { get; set; }
        public string TeamLogoPath { get; set; }
        public Organization Team { get; set; }
        public List<TeamPlayer> Players { get; set; }

        public string GetUniqueName()
        {
            string someId = Id.ToString().Substring(0, 8);
            return Team.Name + "_" + Season + "_" + someId;
        }

    }
}
