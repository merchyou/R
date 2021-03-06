﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roster
{
    class Players
    {
        List<Player> players = new List<Player>();
        public string ListName { get; set; }

        public Players(string _name)
        {
            players = new List<Player>();
            ListName = _name;
        }

        public void AddPlayerToList(Player _player)
        {
            Player tmpPlayer = new Player();
            tmpPlayer = _player;
            players.Add(tmpPlayer);

        }
        public void RemovePlayer(int _id)
        {
            foreach (Player person in players)
            {
                if (person.JerseyNr == _id)
                    players.Remove(person);
            }
        }

        public Player FindPlayer(string _lastName)
        {
            foreach (Player person in players)
            {
                if (person.LastName == _lastName)
                {
                    return person;
                }
            }
            return new Player();

        }
        public Player FindPlayer(int _jerseyNr)
        {
            foreach (Player person in players)
            {
                if (person.JerseyNr == _jerseyNr)
                {
                    return person;
                }
            }
            return new Player();

        }

        public void WriteTeamPlayers()
        {
            Console.WriteLine("Team: " + ListName + "\n");
            foreach (Player person in players)
                person.WritePlayer();
        }
    }
}
