using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance1
{
    enum MenuType
    {
        MainMenu = 1,
        DeveloperRepoSubmenu = 2,
        TeamRepositorySubMenu = 3,
        HRSubmenu = 4
            
    }

    enum MenuAction {Back = 9, Quit = 0 }

    enum DeveloperMenuActions {AddNewDeveloper = 1, UpdateExisting = 2, RemoveDeveloper = 3, ListAllDevelopers = 4 }
}
