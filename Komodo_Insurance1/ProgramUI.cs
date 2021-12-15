using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance1
{
    //enum MenuType
    //{
    //    MainMenu = 1,
    //    DeveloperRepoSubmenu = 2,
    //    TeamRepositorySubMenu = 3,
    //    HRSubmenu = 4
    //}

    public class KomodoApp
    {

        static  MenuType _currentMenu = MenuType.MainMenu;
        
        
        static void Main(string[] args)
        {

            RenderMainMenu();
            ConsoleKeyInfo keypressed = Console.ReadKey();

            while (keypressed.KeyChar != 'q')
            {

                int iPressed = 0;

                if (int.TryParse(keypressed.KeyChar.ToString(), out iPressed))
                {
                    HandleMenuSelection(iPressed);
                }
                else
                    HandleMenuSelection((int) MenuType.MainMenu);

                keypressed = Console.ReadKey();
            }
            

            
        }

        public static void HandleMenuSelection(int iKeyPressed)
        {
            Console.Clear();

            switch (_currentMenu)
            {                
                case MenuType.DeveloperRepoSubmenu:

                    break;

                case MenuType.HRSubmenu:

                    break;
                case MenuType.TeamRepositorySubMenu:

                    break;
                case MenuType.MainMenu:
                    switch (iKeyPressed)
                    {
                        case 1:
                            RenderDeveloperRepositorySubMenu();
                            _currentMenu = MenuType.DeveloperRepoSubmenu;
                            break;
                        case 2:
                            RenderTeamRepositorySubMenu();
                            _currentMenu = MenuType.TeamRepositorySubMenu;
                            break;
                        case 3:
                            RenderHRSubMenu();
                            _currentMenu = MenuType.HRSubmenu;
                            break;
                        default:
                            RenderMainMenu();
                            _currentMenu = MenuType.MainMenu;
                            break;
                    }
                    break;            
            }
        }
        public static void RenderMainMenu()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Welcome to the full Komodo. Choose from below:");
            Console.WriteLine();
            Console.WriteLine("1 - Manage Developer Repository");
            Console.WriteLine("2 - Manage Team Repository");
            Console.WriteLine("3 - HR Functions");
            Console.WriteLine("***********************************************************");
            _currentMenu = MenuType.MainMenu;

        }
        public static void RenderDeveloperRepositorySubMenu()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Manage Developer Repository. Please make a selection from:");
            Console.WriteLine();
            Console.WriteLine("1 - Add New Developer");
            Console.WriteLine("2 - Update existing Developer");
            Console.WriteLine("3 - Remove Existing Developer");
            Console.WriteLine("4 - List All Developers");
            Console.WriteLine("***********************************************************");
            _currentMenu = MenuType.DeveloperRepoSubmenu;
           
        }       
        public static void RenderTeamRepositorySubMenu()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Manage Team Repository Menu, please choose your action below:");
            Console.WriteLine("1 - Add a New team");
            Console.WriteLine("2 - Update Existing Team");
            Console.WriteLine("3 - Remove Existing Team");
            Console.WriteLine("4 - List All Teams");
            Console.WriteLine("***********************************************************");
            _currentMenu = MenuType.TeamRepositorySubMenu;
        }
        public static void RenderHRSubMenu()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("HR Menu. Choose from below:");
            Console.WriteLine("1 - List of New developers ");
            Console.WriteLine("2 - Pluralsight Access");
            Console.WriteLine("***********************************************************");
            _currentMenu = MenuType.HRSubmenu;
        }


    }
}
