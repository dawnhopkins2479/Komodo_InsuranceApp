using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Komodo_Repos
{
    public class DevTeamRepo
    {
        private Dictionary<int, Developer> _listofDevelopers;
        private Dictionary<int, DevTeam> _devTeamList;

        public bool AddDeveloperToTeam(Developer NewTeamMember)
        {
            bool bReturn = false;

            if (!_listofDevelopers.ContainsKey(NewTeamMember.UserID))
            { }
            return (bReturn);
        }

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
        public bool RemoveDeveloperFromTeam(Developer TeamMember)
        {
            return (_listofDevelopers.Remove(TeamMember.UserID));
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
    }
}
