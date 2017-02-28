using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideline.models
{
    public enum Gender { Male, Female }

    public class Athlete
    {
        public Athlete()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string NickName { get; set; }
        public string BattleName { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
    }
}
