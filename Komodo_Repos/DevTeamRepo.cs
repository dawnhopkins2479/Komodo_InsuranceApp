using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Komodo_Repos
{
    public class DevTeamRepo
    {
        
        private Dictionary<int, DevTeam> _devTeamList = new Dictionary<int, DevTeam>();
        private Dictionary<int, Developer> _listOfDevelopers = new Dictionary<int, Developer>();
        

        public bool AddDevTeam(DevTeam devTeam)
        {
            bool bReturn = false;

            if (!_devTeamList.ContainsKey(devTeam.TeamID))
            {
                _devTeamList.Add(devTeam.TeamID, devTeam);
                bReturn = true;
            }
            return bReturn;

        }        
        public void ListAllTeams(IEnumerable<KeyValuePair<int, Developer>> _listOfDevelopers)
        {
            foreach (KeyValuePair<int, Developer> kvp in _listOfDevelopers)
            {
                Developer d = (Developer)kvp.Value;
                Console.WriteLine("{0},{1},{2}", d.FullName, d.UserID, d.HasPluralsight);
            }
        }
        public bool RemoveDevTeam(DevTeam devTeam)
        {
            return (_devTeamList.Remove(devTeam.TeamID));
        }
        public bool UpdateDevTeam(DevTeam devTeam)
        {
            bool bReturn = false;

            if (RemoveDevTeam(devTeam))
            {
                bReturn = AddDevTeam(devTeam);
            }
            return bReturn;
        }
        public bool RemoveDeveloperFromTeam(Developer TeamMember)
        {
            return (_listOfDevelopers.Remove(TeamMember.UserID));
        }
        public bool AddDeveloperToTeam(Developer NewTeamMember)
        {
            bool bReturn = false;

            if (!_listOfDevelopers.ContainsKey(NewTeamMember.UserID))
            {
                _listOfDevelopers.Add(NewTeamMember.UserID, NewTeamMember);
            }
            return (bReturn);
        }
    }
}
