using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolaMUD
{
    /// <summary>
    /// Thing is the parent of just about everything. Mobs, Players, Rooms - they're all Things!
    /// </summary>
	public class Entity
	{
        /// <summary>
        /// The global IndexNumber (or vnum) of the Thing.
        /// </summary>
		public long IndexNumber = 0;

        /// <summary>
        /// The name to use for displaying messages related to this Thing.
        /// </summary>
        public string Name = "";

        /// <summary>
        /// The name to use for command-matching in the parser.
		/// This string is automatically converted to lowercase.
        /// </summary>
		public string HandlingName
		{
			get { return this.handlingName; }
			set { handlingName = value.ToLower(); }
		}
		private string handlingName;

        /// <summary>
        /// Our current location (the Thing we are contained within)
        /// </summary>
        public Entity Location;

        /// <summary>
        /// A list of Things contained within this Thing.
        /// ex. Mobs in a Room
        /// ex. Items in a Mob
        /// </summary>
        public List<Entity> Contents = new List<Entity>();
        
        public Entity()
        {
            Global.Entites.Add(this);
        }

        ~Entity()
        {
            Global.Entites.Remove(this);
        }


    }
}
