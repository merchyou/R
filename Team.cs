using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roster
{
    class Team
    {
        List<Player> players = new List<Player>();
        

        public string TeamName { get; set; }

        public Team(string _teamName)
        {
            players = new List<Player>();
            TeamName = _teamName;
        }

        public void AddPlayer(Player _player)
        {
            int id = players.Count;
            
            if (id>=53)
            {
                Console.WriteLine("You can't have more than 53 players in your roster");
            }
            else
            {
                Player tmpPlayer = _player;
                players.Add(tmpPlayer);
            }
        }
        

        public void RemovePlayer(Player _player)
        {
            /*foreach(Player person in players)
            {
                if (person.JerseyNr == _player)
                    players.Remove(person);
            }*/
            Player tmpPlayer = _player;
            players.Remove(tmpPlayer);
        }

        public Player FindPlayer(int _jerseyNr)
        {
            foreach(Player person in players)
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
            Console.WriteLine("Team: " + TeamName + "\n");
            foreach (Player person in players)
                person.WritePlayer();
        }
    }
}
