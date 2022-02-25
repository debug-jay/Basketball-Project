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
        /*  bPlayers    - Gets The Current Directory & File of the Basketball Players
         *  bTeams      - Gets The Current Directory & File of the Basketball Teams
         * 
         * 
         * 
         * 
         */
        public Random rand = new Random();

        // private variables
        public static string bPlayers = Path.Combine(Directory.GetCurrentDirectory(), "BasketballPlayers.txt");
        public static string[] names = File.ReadAllLines(bPlayers);
        public static string bTeams = Path.Combine(Directory.GetCurrentDirectory(), "BasketballTeams.txt");
        public static string[] teams = File.ReadAllLines(bTeams);
        public int gInput;

        public static List<string> mlist = new List<string>(names);
        public static List<string> tlist = new List<string>(teams);


    }

    public class BasketballPlayers : BasketballTeams
    {


        private List<string> listNames1 = new List<string>();
        private List<string> listNames2 = new List<string>();
        private List<string> listNames3 = new List<string>();
        private List<string> listNames4 = new List<string>();
        private List<string> listNames5 = new List<string>();

        
        public void PrintTeams()
        {
            //this.Team = this.teams;
          
            while (true)
            {

                Console.Clear();
                Console.WriteLine("TEAMS & ROSTERS\n");
                //Console.WriteLine("Teams:");
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

                        break;

                    case 2:
                       
                        RosterTwo();

                        break;

                    case 3:
                        
                        RosterThree();

                        break;

                    case 4:
                        
                        RosterFour();

                        break;

                    case 5:
                     
                        RosterFive();

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
            while (true)
            {

                Console.WriteLine('\n' + "Press '0' to go back ");
                Console.Write("Input: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa787090a: Please Enter '0' To Return To Teams List");
                        break;

                }
                if (input == 0)
                {
                    break;
                }
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
            while (true)
            {

                Console.WriteLine('\n' + "Press '0' to go back ");
                Console.Write("Input: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa787090a: Please Enter '0' To Return To Teams List");
                        break;

                }
                if (input == 0)
                {
                    break;
                }
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
            while (true)
            {

                Console.WriteLine('\n' + "Press '0' to go back ");
                Console.Write("Input: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa787090a: Please Enter '0' To Return To Teams List");
                        break;

                }
                if (input == 0)
                {
                    break;
                }
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

            while (true)
            {

                Console.WriteLine('\n' + "Press '0' to go back ");
                Console.Write("Input: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa787090a: Please Enter '0' To Return To Teams List");
                        break;

                }
                if(input == 0)
                {
                    break;
                }
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

            while (true)
            {

                Console.WriteLine('\n' + "Press '0' to go back ");
                Console.Write("Input: ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Error: INPUT_INVALID$ 0xa787090a: Please Enter '0' To Return To Teams List");
                        break;

                }
                if (input == 0)
                {
                    break;
                }
            }
        }


    }

}
