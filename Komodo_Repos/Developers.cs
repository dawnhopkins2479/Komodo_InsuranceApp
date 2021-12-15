using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Repos
{
    public class Developer
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName}{LastName}";
        public bool HasPluralsight { get; set; }

        public Developer() { }

        public Developer(string firstName, string lastName, int userID, bool hasPluralsight)
        {
            UserID = userID;
            FirstName = firstName;
            LastName = lastName;
            HasPluralsight = hasPluralsight;
        }
    }
}
