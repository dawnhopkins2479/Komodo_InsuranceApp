using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Repos
{
    public class DevTeam
    {
        private Dictionary<int, Developer> _listOfDevelopers;
        public string TeamName { get; set; }
        public int TeamID { get; set; }

        public DevTeam() { }

        public DevTeam(string teamName, int teamId)
        {
            TeamName = teamName;
            TeamID = teamId;
        }
    }
}
