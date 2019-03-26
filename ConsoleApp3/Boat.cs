using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Boat
    {
        public Bank Side { get; private set; }
        Actor occupant;
        public Boat()
        {
            Side = Bank.LEFT;
        }
        internal Bank Bank
        {
            get => default(Bank);
            set
            {
            }
        }
        public Bank crossTheRiver()
        {
            if(Side == Bank.LEFT)
            {
                Side = Bank.RIGHT;
            }
            else
            {
                Side = Bank.LEFT;
            }
            updateBoatOccupantPosition();
            return Side;
        }
        private void updateBoatOccupantPosition()
        {
            if (occupant != null)
            {
                occupant.changeBank();
                occupant = null;
            }
        }
        public void putInBoat(Actor actor)
        {
            occupant = actor;
        }
        public string getBoatOccupant()
        {
            if (occupant == null)
                return "empty";
            else
                return occupant.Name;
        }
        public String reportOnPosition()
        {
            return $"The boat is on the {Side} bank";
        }
    }
}
