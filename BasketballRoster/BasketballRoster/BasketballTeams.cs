using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace BasketballRoster
{
    public class BasketballTeams
    {
        public string[] Team { get; set; }
        public string[] teams = File.ReadAllLines("BasketballTeams.txt");

        BasketballPlayers players = new BasketballPlayers();

        // private variables
        
        public void PrintTeams()
        {
            this.Team = this.teams;
            Console.Clear();
            Console.WriteLine("TEAMS & ROSTERS");
            Console.WriteLine('\n' + "Teams:");

            

            while (true)
            {
                Console.WriteLine('\n' + "Press Teams Corresponding Number To List Roster, Press '0' to go back");

                for (int i = 1; i < 6; i++)
                {
                    Console.Write(i + ": ");
                    Console.WriteLine(this.Team[i]);
                }

                Console.Write("Input: ");
                int gInput = Convert.ToInt32(Console.ReadLine());


                switch (gInput)
                {
                    case 0:

                        Console.WriteLine("Returning . . .");
                        Thread.Sleep(1500); // sleep program for 1.5 seconds
                        break;

                    case 1:

                        players.RosterOne();

                        break;

                    case 2:

                        players.RosterTwo();

                        break;

                    case 3:

                        players.RosterThree();

                        break;

                    case 4:

                        players.RosterFour();

                        break;

                    case 5:

                        players.RosterFive();

                        break;

                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa748090a: Please Enter (1 - 5, 0 To Return To Main Menu)");
                        break;

                }

                if (gInput == 0)
                {
                    break;
                }
                else
                    continue;
            }


        }
    }

    public class BasketballPlayers
    {

        Random rand = new Random();

        public string[] names = File.ReadAllLines("BasketballPlayers.txt");

        public string[] Name { get; set; }

        List<string> listNames1 = new List<string>();
        List<string> listNames2 = new List<string>();
        List<string> listNames3 = new List<string>();
        List<string> listNames4 = new List<string>();
        List<string> listNames5 = new List<string>();


        public void RosterOne()
        {
            this.Name = this.names;
            Console.Clear();
            Console.WriteLine("TEAMS & ROSTERS");
            Console.WriteLine('\n' + "Roster:" + '\n');
            if (listNames1.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames1.Add(Name[rand.Next(1, 99)]);
                }
            }
            for (int i = 1; i < listNames1.Count; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(listNames1[i]);

            }
            
        }
        public void RosterTwo()
        {
            this.Name = this.names;
            Console.Clear();
            Console.WriteLine("TEAMS & ROSTERS");
            Console.WriteLine('\n' + "Roster:" + '\n');
            if (listNames2.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames2.Add(Name[rand.Next(1, 99)]);
                }
            }
            for (int i = 1; i < listNames2.Count; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(listNames2[i]);

            }
        }
        public void RosterThree()
        {
            this.Name = this.names;
            Console.Clear();
            Console.WriteLine("TEAMS & ROSTERS");
            Console.WriteLine('\n' + "Roster:" + '\n');
            if (listNames3.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames3.Add(Name[rand.Next(1, 99)]);
                }
            }
            for (int i = 1; i < listNames3.Count; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(listNames3[i]);

            }
        }
        public void RosterFour()
        {
            this.Name = this.names;
            Console.Clear();
            Console.WriteLine("TEAMS & ROSTERS");
            Console.WriteLine('\n' + "Roster:" + '\n');
            if (listNames4.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames4.Add(Name[rand.Next(1, 99)]);
                }
            }
            for (int i = 1; i < listNames4.Count; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(listNames4[i]);

            }
        }
        public void RosterFive()
        {
            this.Name = this.names;
            Console.Clear();
            Console.WriteLine("TEAMS & ROSTERS");
            Console.WriteLine('\n' + "Roster:" + '\n');
            if (listNames5.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames5.Add(Name[rand.Next(1, 99)]);
                }
            }
            for (int i = 1; i < listNames5.Count; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(listNames5[i]);

            }
        }


    }   


}
