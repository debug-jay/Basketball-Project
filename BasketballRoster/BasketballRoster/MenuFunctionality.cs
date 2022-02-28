using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace BasketballRoster
{
    public class MenuFunctionality
    {
        #region Main Menu Variables
        private bool isCheck = false;
        private int uInput;
        private BasketballPlayers player = new BasketballPlayers();
        #endregion

        #region Main Menu Functionality
        public void Menu()
        {
            
            while (!isCheck)
            {
                
                Console.Clear();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine('\n' + "Press Corresponding Number for Your Intentional Action" + '\n');

                Console.Write("1: List Teams & Roster" + '\n' +
                                  "2: List Teams in Finals" + '\n' + 
                                  "3: Quit ");

                uInput = Convert.ToInt32(Console.ReadLine());

                switch (uInput)
                {
                    case 1:
                        player.PrintTeams();
                        break;

                    case 2:
                        /*Console.WriteLine("Owner Needs to Update"); // Do this Tomorrow
                        Thread.Sleep(500);*/

                        player.ListFinalTeams();
                        
                        break;

                    case 3:

                        Console.Write("Quitting ");
                        Thread.Sleep(350);
                        Console.Write(". ");
                        Thread.Sleep(250);
                        Console.Write(". ");
                        Thread.Sleep(250);
                        Console.WriteLine(". ");
                        Thread.Sleep(100);

                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa748090a: Please Enter (1 Or 2)");
                        break;
                }

            }
        }
        #endregion
    }
}
