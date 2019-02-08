using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn
{
    class Boat
    {
        Bank side;
        Actor occupant;
        public Boat()
        {
            side = Bank.LEFT;
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
            if(side == Bank.LEFT)
            {
                side = Bank.RIGHT;
            }
            else
            {
                side = Bank.LEFT;
            }
            updateBoatOccupantPosition();
            return side;
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
    }
}
