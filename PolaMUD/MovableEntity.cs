using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolaMUD
{
    public class MovableEntity : Entity
    {
        /*public delegate void PreMove(Entity targetLocation);
        public event PreMove PreMove;
        public delegate void OnMove(Entity targetLocation);
        public event OnMove OnMove;*/

        public bool CanMove(Entity targetEntity)
        {
            return true;
        }

        public bool Move(Entity targetEntity)
        {
            var currentLocation = Location;

            if (!CanMove(targetEntity))
            {
                return false;
            }

            if (Location != null)
            {
                Location.Contents.Remove(this);
                Location = null;
            }

            targetEntity.Contents.Add(this);
            Location = targetEntity;

            return true;
        }

        public bool Move(Entity targetEntity, string message)
        {
            var ret = Move(targetEntity);
            return ret;
        }
    }
}
