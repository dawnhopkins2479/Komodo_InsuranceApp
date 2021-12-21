using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Repos
{
    public class DeveloperRepo
    {
        private Dictionary<int, Developer> _listOfDevelopers = new Dictionary<int, Developer>();
        

     
       
        public bool AddDeveloper(Developer developer)
        {
            bool bReturn = false;

            if (!_listOfDevelopers.ContainsKey(developer.UserID))
            {
                _listOfDevelopers.Add(developer.UserID, developer);
                bReturn = true;
            }
            return bReturn;

        }
        public bool RemoveDeveloper(Developer developer)
        {
            return(_listOfDevelopers.Remove(developer.UserID));
        }
        public bool UpdateDeveloper(Developer developer)
        {
            bool bReturn = false;

            if (RemoveDeveloper(developer))
            {
                bReturn = AddDeveloper(developer);
                
            }
            return bReturn;
        }

        public void ListAllDevelopers()
        {
            foreach (KeyValuePair<int,Developer> kvp in _listOfDevelopers)
            {
                Developer d = (Developer) kvp.Value;
                Console.WriteLine("{0},{1},{2}", d.FullName, d.UserID, d.HasPluralsight);
            }
        }

    }
}

