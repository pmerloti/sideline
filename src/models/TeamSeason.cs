using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    [DataContract]
    public class TeamSeason
    {
        public TeamSeason(Team team, Season season)
        {
            Id = Guid.NewGuid();
            Team = team;
            Season = season;
        }

        [DataMember]
        public Guid Id { get; private set; }

        [DataMember]
        public Team Team { get; private set; }

        [DataMember]
        public Season Season { get; private set; }

        //i.e.: Seniors & Juniors, 14U, etc
        [DataMember]
        public string AgeBracket { get; set; }

        [DataMember]
        public string HeadCoach { get; set; }

        [DataMember]
        public string AssistantCoach { get; set; }

        [DataMember]
        public string Colors { get; set; }

        [DataMember]
        public string TeamPicturePath { get; set; }

        [DataMember]
        public string TeamLogoPath { get; set; }

        public string GetUniqueName()
        {
            string someId = Id.ToString().Substring(0, 8);
            return Team.TeamName + "_" + Season.Name + "_" + someId;
        }
    }
}
