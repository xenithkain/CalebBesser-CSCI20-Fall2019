using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG
{
    class Rooms
    {
        public string Event;
        public int Position;
        public string Name;
        public int Game_State_Number;

        public Rooms(string aEvent, int aGame_State_Number, int aPosition, string aName)
        {
            Event = aEvent;
            Position = aPosition;
            Name = aName;
            Game_State_Number = aGame_State_Number;
        }
    }
}
