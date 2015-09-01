using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolaMUD
{
	public class Exit : Entity
	{
		public long FromRoom;
		public long ToRoom;

		public bool Visible = true;

		public bool Door = false;
		public bool Closed = false;
		public bool Locked = false;
		public int LockDifficulty = 0;
		public int Key;

		public Exit()
		{
		}

		public Exit(long toRoom)
		{
			ToRoom = toRoom;
            Name = "Exit to " + toRoom;
		}

		public Exit(long fromRoom, long toRoom)
		{
			FromRoom = fromRoom;
			ToRoom = toRoom;
            Name = "Exit from " + fromRoom + " to " + toRoom;
        }
	}
}
