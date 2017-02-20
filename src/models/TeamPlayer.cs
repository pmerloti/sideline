using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    public class TeamPlayer
    {
        public Guid Id { get; set; }
        public string JerseyNumber { get; set; }
        public TeamSquad Squad { get; set; }
        public Athlete Player { get; set; }
        public string School { get; set; }
        public string Grade { get; set; }
        public string Position { get; set; }
        public double Height_m { get; set; }
        public double Weight_kg { get; set; }
        public double NoJumpHeight_m { get; set; }
        public double SpikeHeight_m { get; set; }
        public double BlockHeight_m { get; set; }
        public string PhotoPath { get; set; }
    }
}
