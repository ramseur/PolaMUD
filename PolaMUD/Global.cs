using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace PolaMUD
{
	public static class Global
	{
		public static Server Server;
        public static GameLoop GameLoop;
		public static Commands Commands = new Commands();

        public static List<Entity> Entites = new List<Entity>();
        public static Dictionary<long, Area> AreaTable = new Dictionary<long, Area>();
        public static Dictionary<long, Room> RoomTable = new Dictionary<long, Room>();
        public static Dictionary<long, XmlNode> MobLoadTable = new Dictionary<long, XmlNode>();
        public static Dictionary<long, object> ObjLoadTable = new Dictionary<long, object>();
        public static Dictionary<string, Skill> SkillTable = new Dictionary<string, Skill>();
        public static Dictionary<string, Terrain> TerrainTable = new Dictionary<string, Terrain>();
        public static List<Mob> Mobs = new List<Mob>();
        public static List<Player> Players = new List<Player>();
        public static IEnumerable<Mob> PlayersMobs
        {
            get
            {
                return Players.Concat(Mobs);
            }
        }


        public const int TickDuration = 100;  // pulses
        public const int RoundDuration = 30;  // pulses
        public const int PulseDuration = 10; // milliseconds

		public static Room Limbo;

        public static void Log(string message)
        {
            Server.Application.Log(message);
        }

        public static void Error(string message)
        {
            Server.Application.Error(message);
        }

        public static Room GetRoom(long indexNumber)
		{
			if (RoomTable.ContainsKey(indexNumber))
			{
				return RoomTable[indexNumber];
			}

			return null;
		}

        public static void SendToAll(string msg, string mobileMessage)
        {
            foreach (Player player in Global.Players)
            {
                player.SendMessage(msg, mobileMessage);
            }
        }

    }
}
