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
        #region Teams and Players Main Variables
        protected Random rand = new Random();

        // private variables
        protected static string bPlayers = Path.Combine(Directory.GetCurrentDirectory(), "BasketballPlayers.txt");
        protected static string[] names = File.ReadAllLines(bPlayers);
        protected static string bTeams = Path.Combine(Directory.GetCurrentDirectory(), "BasketballTeams.txt");
        protected static string[] teams = File.ReadAllLines(bTeams);
        protected int gInput;
        protected int tinput;

        protected static List<string> mlist = new List<string>(names);
        protected static List<string> tlist = new List<string>(teams);
        #endregion

    }

    public class BasketballPlayers : BasketballTeams
    {
        #region Main Basketball Teams / Players Variables
        // For the PrintTeams Function
        private List<string> listNames1 = new List<string>();
        private List<string> listNames2 = new List<string>();
        private List<string> listNames3 = new List<string>();
        private List<string> listNames4 = new List<string>();
        private List<string> listNames5 = new List<string>();

        // For the Mint Players / List FinalTeams Function
        private List<string> listTeam1 = new List<string>();
        private List<string> listTeam2 = new List<string>();
        private List<string> players1 = new List<string>();
        private List<string> players2 = new List<string>();
        #endregion

        #region Main Basketball Teams / Players Function
        public void PrintTeams()
        {
            while (true)
            {

                Console.Clear();
                Console.WriteLine("TEAMS & ROSTERS\n");
                
                int i = 1;
                for (int x = i; x < 6; x++)
                {
                    Console.Write(i + ": ");
                    Console.WriteLine(tlist[x]);
                    i++;
                }
                Console.WriteLine('\n' + "Press Teams Corresponding Number To List Roster, Press '0' to go back");
                Console.Write("Input: ");

                gInput = Convert.ToInt32(Console.ReadLine());

                switch (gInput)
                {
                    case 0:

                        Console.Write("Returning ");

                        Thread.Sleep(350);
                        Console.Write(". ");
                        Thread.Sleep(250);
                        Console.Write(". ");
                        Thread.Sleep(250);
                        Console.WriteLine(". ");
                        Thread.Sleep(100);
                        break;

                    case 1:
                        
                        RosterOne();
                        askInput();
                        break;

                    case 2:
                       
                        RosterTwo();
                        askInput();
                        break;

                    case 3:
                        
                        RosterThree();
                        askInput();
                        break;

                    case 4:
                        
                        RosterFour();
                        askInput();
                        break;

                    case 5:
                     
                        RosterFive();
                        askInput();
                        break;

                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa748090a: Please Enter (1 - 5, 0 To Return To Main Menu)");
                        break;

                }

                if (gInput == 0)
                {
                    break;
                }
                
            }
        }

        public void askInput()
        {
            while (true)
            {
                Console.WriteLine('\n' + "Press '0' to go back ");
                Console.Write("Input: ");
                int vinput = Convert.ToInt32(Console.ReadLine());
                switch (vinput)
                {
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa787090a: Please Enter '0' To Return To Teams in Finals List");
                        break;

                }
                if (vinput == 0)
                {
                    break;
                }
            }
        }

        public void RosterOne()
        {
            //this.Name = this.names;
            Console.Clear();
            Console.WriteLine("ROSTER: " + teams[1] + '\n');
            if (listNames1.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames1.Add(mlist[rand.Next(1, 99)]);

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
            //this.Name = this.names;
            Console.Clear();
            Console.WriteLine("ROSTER: " + teams[2] + '\n');
            if (listNames2.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames2.Add(mlist[rand.Next(100,199)]);
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
            //this.Name = this.names;
            Console.Clear();
            Console.WriteLine("ROSTER: " + teams[3] + '\n');
            if (listNames3.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames3.Add(mlist[rand.Next(200,299)]);
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
            //this.Name = this.names;
            Console.Clear();
            Console.WriteLine("ROSTER: " + teams[4] + '\n');
            if (listNames4.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames4.Add(mlist[rand.Next(300, 399)]);
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
            //this.Name = this.names;
            Console.Clear();
            Console.WriteLine("ROSTER: " + teams[5] + '\n');
            if (listNames5.Count < 15)
            {
                for (int j = 0; j < 16; j++)
                {
                    listNames5.Add(mlist[rand.Next(400, 499)]);
                }
            }
            for (int i = 1; i < listNames5.Count; i++)
            {
                Console.Write(i + ": ");
                Console.WriteLine(listNames5[i]);

            }     
        }

        public void ListFinalTeams()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("TEAMS IN FINALS " + '\n');
                if (listTeam1.Count < 1 && listTeam2.Count < 1)
                {
                    for (int i = 0; i < 1; i++)
                    {
                        listTeam1.Add(tlist[rand.Next(1, 3)]);
                        listTeam2.Add(tlist[rand.Next(4, 6)]);
                    }
                }
                for (int x = 0; x < listTeam1.Count; x++)
                {
                    Console.WriteLine("1: " + listTeam1[x]);
                    Console.WriteLine("2: " + listTeam2[x]);

                }

                Console.WriteLine('\n' + "Press Teams Corresponding Number To List Roster, Press '0' to go back");
                Console.Write("Input: ");
                tinput = Convert.ToInt32(Console.ReadLine());

                switch (tinput)
                {
                    case 0:

                        Console.Write("Returning ");

                        Thread.Sleep(350);
                        Console.Write(". ");
                        Thread.Sleep(250);
                        Console.Write(". ");
                        Thread.Sleep(250);
                        Console.WriteLine(". ");
                        Thread.Sleep(100);
                        break;

                    case 1:

                        if (listTeam1[0] == tlist[1])
                        {
                            RosterOne();
                            askInput();
                        }
                        else if (listTeam1[0] == tlist[2])
                        {
                            RosterTwo();
                            askInput();
                        }
                        else if (listTeam1[0] == tlist[3])
                        {
                            RosterThree();
                            askInput();
                        }
                        else if (listTeam1[0] == tlist[4])
                        {
                            RosterFour();
                            askInput();
                        }
                        else if (listTeam1[0] == tlist[5])
                        {
                            RosterFive();
                            askInput();
                        }
                        else
                        {
                            MintPlayers1();
                            askInput();
                        }
                        break;

                    case 2:

                        if (listTeam2[0] == tlist[1])
                        {
                            RosterOne();
                            askInput();
                        }
                        else if (listTeam2[0] == tlist[2])
                        {
                            RosterTwo();
                            askInput();
                        }
                        else if (listTeam2[0] == tlist[3])
                        {
                            RosterThree();
                            askInput();
                        }
                        else if (listTeam2[0] == tlist[4])
                        {
                            RosterFour();
                            askInput();
                        }
                        else if (listTeam2[0] == tlist[5])
                        {
                            RosterFive();
                            askInput();
                        }
                        else
                        {
                            MintPlayers2();
                            askInput();
                        }
                        break;

                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa787090a: Please Enter '0' To Return To Main Menu");
                        break;
                }

                if (tinput == 0)
                {
                    break;
                }

            }
        }

        private void MintPlayers1()
        {
            Console.Clear();
            Console.WriteLine("ROSTER: " + listTeam1[0] + '\n');
            if (players1.Count == 0)
            {
                for (int i = 1; i < 16; i++)
                {
                    players1.Add(mlist[rand.Next(500, 549)]);
                }
            }
            for (int x = 0; x < players1.Count; x++)
            {
                Console.Write(x + ": ");
                Console.WriteLine(players1[x]);
            }
        }
        private void MintPlayers2()
        {
            Console.Clear();
            Console.WriteLine("ROSTER: " + listTeam2[0] + '\n');
            if (players2.Count == 0)
            {
                for (int i = 1; i < 16; i++)
                {
                    players2.Add(mlist[rand.Next(550, 599)]);
                }
            }
            for (int x = 0; x < players2.Count; x++)
            {
                Console.Write(x + ": ");
                Console.WriteLine(players2[x]);
            }
        }
        #endregion
    }
}
