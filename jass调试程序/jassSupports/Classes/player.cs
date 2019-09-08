using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Map
{
    using integer = System.Int32;
    using real = System.Single;
    using boolean = System.Boolean;
    using @string = System.String;
    using code = System.Delegate;

    public class player : agent
    {
        public race race;
        public integer index;
        public playercolor color;
        public @string Name;

        public boolean isRemoved = false;

        private player() { }
        public static player get(int a)
        {
            if (Players[a] == null) Players[a] = new player() { index = a };
            return Players[a];
        }
        private static player[] Players = new player[16];

        public static implicit operator int(player player)
        {
            return player.index;
        }
        public static implicit operator player(int _player)
        {
            return player.get(_player);
        }
    }
}