﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roster
{
    class Player
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int JerseyNr { get; set; }
        public string Position { get; set; }

        public Player(string _name, string _lastName, int _jerseyNr, string _position)
        {
            Name = _name;
            LastName = _lastName;
            JerseyNr = _jerseyNr;
            Position = _position;
        }

        public Player()
        {
        }

        public void WritePlayer()
        {
            Console.WriteLine(Name + "\n" + LastName + "#" + JerseyNr + "\n" + Position);
        }

    }
}
