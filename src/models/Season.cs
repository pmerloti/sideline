using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    public class Season
    {
        public Season()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        //i.e.: 2015-2016 Season, 2016 Summer Season, etc
        public string Name { get; set; }
    }
}
