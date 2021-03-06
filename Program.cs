﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            Players Players = new Players("List of players");
            Team Roster = new Team("Roster");


            Console.WriteLine("Hello! Let's start working on your team roster:");
            while (true)
            {
                Console.WriteLine("1. Add player to a list");
                Console.WriteLine("2. Add player to your team roster");
                Console.WriteLine("3. Remove player from your team roster");
                Console.WriteLine("4. Find players in the list(by Jersey number)");
                Console.WriteLine("5. Find players in the list (by last name)");
                Console.WriteLine("6. Show all your team players");
                Console.WriteLine("7. Show all players");

                int choice = 0;
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {

                    case 1:
                        {
                            Console.WriteLine("put in name:");
                            string _name = Console.ReadLine();
                            Console.WriteLine("Last name:");
                            string _lastName = Console.ReadLine();
                            Console.WriteLine("Jersey number:");
                            int _jerseyNr = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Players position:");
                            string _position = Console.ReadLine();
                            Player tmpPlayer = new Player(_name, _lastName, _jerseyNr, _position);
                            Players.AddPlayerToList(tmpPlayer);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Put in players last name:");
                            string tmpLastName = Console.ReadLine();
                            Player tmpPlayer = Players.FindPlayer(tmpLastName);
                            Roster.AddPlayer(tmpPlayer);
                            break;
                        }

                    case 3:
                        {
                            Console.WriteLine("Put in players last name:");
                            string tmpLastName = Console.ReadLine();
                            Player tmpPlayer = Players.FindPlayer(tmpLastName);
                            Roster.RemovePlayer(tmpPlayer);
                            break;
                        }

                    case 4:
                        {
                            Console.WriteLine("What's jersey nr then?");
                            int _jerseyNr = Convert.ToInt32(Console.ReadLine());
                            Player find = Players.FindPlayer(_jerseyNr);
                            find.WritePlayer();
                            break;
                            
                        }

                    case 5:
                        {
                            Console.WriteLine("What's last name then?");
                            string _lastName = Console.ReadLine();
                            Player find = Players.FindPlayer(_lastName);
                            find.WritePlayer();
                            break;
                        }

                    case 6:
                        {
                            Roster.WriteTeamPlayers();
                            break;
                        }

                    case 7:
                        {
                            Players.WriteTeamPlayers();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("This is not an option!");
                            break;
                        }

                }

            }
        }
    }
}
