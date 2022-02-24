using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballRoster
{
    public class MenuFunctionality
    {

        // General variables
        BasketballTeams teams = new BasketballTeams();
        
        // private variables
        private bool isCheck = false;


        // public variables
        
        public void Menu()
        {// Write out Menu & Functionality
            
            while (!isCheck)
            {
                
                Console.Clear();
                Console.WriteLine("MAIN MENU");
                Console.WriteLine('\n' + "Press Corresponding Number for Your Intentional Action" + '\n');

                Console.WriteLine("1: List Teams & Roster" + '\n' +
                                  "2: List Teams in Finals");

                int uInput = Convert.ToInt32(Console.ReadLine());

                switch (uInput)
                {
                    case 1:
                        teams.PrintTeams();
                        break;

                    case 2:
                        Console.WriteLine("Owner Needs to Update");
                        break;

                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa748090a: Please Enter (1 Or 2)");
                        break;
                }

            }
        }

    }
}
