using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    class TeamPlayer
    {
        public Guid Id { get; set; }
        public string JerseyNumber { get; set; }
        public Team Team { get; set; }
        public Player Player { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public string Position { get; set; }
        public double HeightMeters { get; set; }
        public double WeightKilos { get; set; }
        public double NoJumpHeightMeters { get; set; }
        public double SpikeHeightMeters { get; set; }
        public double BlockHeightMeters { get; set; }
        public string School { get; set; }
        public string PhotoPath { get; set; }
    }
}
