using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stuctures
{
    internal class Program
    {
        struct Teams //Creates a structure called teams
        {
            public string name; //Name of teams
            public int wins; //Wins
            public int loss;//Looses
            public int points;//Points

        }
        
        static void Main(string[] args) //Main
        {
            bool online = true;
            Teams[] table = new Teams[6]; //Creates an array with all the values from the struct
            while (online == true)
            {
                int choice = 0;
                Console.WriteLine("Welcome to team Leagues creating!");
                Console.WriteLine("Please choose an option: ");
                Console.WriteLine("[1] Create your leagues ");
                Console.WriteLine("[2] View teams ");
                Console.WriteLine("[3] Exit ");
                choice = int.Parse(Console.ReadLine());
                switch (choice) //Switch statment for option values
                {
                    case 1: //If enter option 1
                        Console.WriteLine("You have choosen to Create a League!");
                        CreateLeague(ref table);//Calls the CreateLeauge method and passes table array
                        Console.WriteLine("Teams have been succesfully entered!");
                        Console.WriteLine("Would you like to go back to main menu? (y/n");
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            Console.WriteLine("Returning to menu....");
                            Console.WriteLine("\n");
                        }
                        else if (answer == "n")
                        {
                            Console.WriteLine("Exiting the program");
                            online = false;
                        }
                        else
                        {
                            Console.WriteLine("Invaid input | Returning to main menu");
                            Console.WriteLine("\n");
                            return;
                        }
                        break;
                    case 2:
                        Console.WriteLine("You have choosen to View all the teams!");
                        ViewTeams(ref table);//Calls the CreateLeauge method and passes table array
                        break;
                    default:
                        Console.WriteLine("An error has occured");
                        break;
                }
                Console.ReadLine();
            }
        }
        static void CreateLeague(ref Teams[]table)
        {
            for (int i = 0; i<6; i++)
            {
                Console.WriteLine("Please enter your team name: ");
                table[i].name = Console.ReadLine();
                Console.WriteLine("Enter the number of team wins: ");
                table[i].wins = int .Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of team losses: ");
                table[i].loss = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of team point: ");
                table[i].points = int.Parse(Console.ReadLine());

                

            }

            
            
        }
        static void ViewTeams(ref Teams[] table)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Team:" +table[i].name+ "\t ");
                Console.Write("Team wins: "+table[i].wins+ "\t ");
                Console.Write("Team losses:" + table[i].loss + "\t ");
                Console.Write("Team points: " + table[i].points+ "\t ");
                Console.Write("\n");


            }



        }

    }
}
