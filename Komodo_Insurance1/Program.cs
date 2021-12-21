
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Komodo_Repos;

namespace Komodo_Insurance1
{
    //enum MenuType
    //{
    //    MainMenu = 1,
    //    DeveloperRepoSubmenu = 2,
    //    TeamRepositorySubMenu = 3,
    //    HRSubmenu = 4
    //}

    public class Program
    {

        static  MenuType _currentMenu = MenuType.MainMenu;
        
        
        public static void Main(string[] args)
        {
          
            RenderMainMenu();

            ConsoleKeyInfo keypressed;
            char cKeyPressed; 
            bool bRun = true;

            while (bRun)
            {
                keypressed = Console.ReadKey();
                cKeyPressed = keypressed.KeyChar;
                int iPressed = 0;


                if (int.TryParse(cKeyPressed.ToString(), out iPressed))
                {
                    switch ((MenuAction)iPressed)
                    {
                        case MenuAction.Back:
                            RenderMainMenu();
                            break;
                        case MenuAction.Quit:
                            bRun = false;
                            break;
                        default:
                            HandleMenuSelection(iPressed);
                            break;
                    }

                }


            }
            

            
        }

        private static Developer ParseDeveloperFromInput(string input)
        {
            string[] aInput = input.Split(',');

            if (aInput.Length == 4)
            {
                return new Developer(aInput[0], aInput[1], Convert.ToInt32(aInput[2]), Convert.ToBoolean(aInput[3]));
            }
            else
            {
                Console.WriteLine("Bad format for developer input");
            }

            return null;
        }
        private static DevTeam ParseDevTeamFromInput(string input)
        {
            string[] aInput = input.Split(',');

            if (aInput.Length == 2)
            {
                return new DevTeam(aInput[0], Convert.ToInt32(aInput[1]));
            }
            else
            {
                Console.WriteLine("Not enough input for Team");
            }

            return null;
        }
        

        public static void HandleMenuSelection(int iKeyPressed)
        {
            

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
                            
                            break;
                        case 2:
                            RenderTeamRepositorySubMenu();
                            
                            break;
                        case 3:
                            RenderHRSubMenu();
                            
                            break;
                        default:
                            
                            
                            break;
                    }
                    break;            
            }
        }
        public static void RenderMainMenu()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Welcome to the full Komodo. Choose from below:");
            Console.WriteLine();
            Console.WriteLine("1 - Manage Developer Repository");
            Console.WriteLine("2 - Manage Team Repository");
            Console.WriteLine("3 - HR Functions");
            Console.WriteLine("0 - QUIT");
            Console.WriteLine("***********************************************************");
            _currentMenu = MenuType.MainMenu;

        }
        public static void RenderDeveloperRepositorySubMenu()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Manage Developer Repository. Please make a selection from:");
            Console.WriteLine();
            Console.WriteLine("1 - Add New Developer");
            Console.WriteLine("2 - Update existing Developer");
            Console.WriteLine("3 - Remove Existing Developer");
            Console.WriteLine("4 - List All Developers");
            Console.WriteLine("9 - Back to Main Menu");
            Console.WriteLine("0 - Quit");
            Console.WriteLine("***********************************************************");
            _currentMenu = MenuType.DeveloperRepoSubmenu;
           
        }       
        public static void RenderTeamRepositorySubMenu()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Manage Team Repository Menu, please choose your action below:");
            Console.WriteLine("1 - Add a New team");
            Console.WriteLine("2 - Update Existing Team");
            Console.WriteLine("3 - Remove Existing Team");
            Console.WriteLine("4 - List All Teams");
            Console.WriteLine("9 - Back to Main Menu");
            Console.WriteLine("0 - Quit");
            Console.WriteLine("***********************************************************");
            _currentMenu = MenuType.TeamRepositorySubMenu;
        }
        public static void RenderHRSubMenu()
        {
            Console.Clear();
            Console.WriteLine("***********************************************************");
            Console.WriteLine("HR Menu. Choose from below:");
            Console.WriteLine("1 - List of New developers ");
            Console.WriteLine("2 - Pluralsight Access");
            Console.WriteLine("9 - Back to Main Menu");
            Console.WriteLine("0 - Quit");
            Console.WriteLine("***********************************************************");
            _currentMenu = MenuType.HRSubmenu;
        }
    }
}
