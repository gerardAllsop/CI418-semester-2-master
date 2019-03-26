using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FoxGooseCorn
{
    public class Puzzle
    {    
        Help help;
        Cast cast;
        Boat boat;

        public Puzzle()
        {
            //actors in the puzzle
            cast = new Cast();
            //a boat
            boat = new Boat();
            //instance of help
            help = new Help();          
        }

        public void printAllPlayerPositions()
        {
            WriteLine(cast.getAllPositions());
            WriteLine(boat.reportOnPosition());
        }

        public String getAllPlayerPositions()
        {
            StringBuilder output = new StringBuilder();
            output.Append(cast.getAllPositions());
            output.Append(boat.reportOnPosition());
            return output.ToString();
        }

        public void printIntro()
        {
            WriteLine(help.getIntroTxt());
        }

        public String getIntro()
        {
            return help.getIntroTxt();
        }

        public void printInstructions()
        {
            WriteLine(help.getMenuText());
        }

        public void whereIsPlayer(String player)
        {
            if (cast.isValidCastMember(player))
            {
                WriteLine(cast.getCastMemberPosition(player));
            }
        }

        public void putInBoat(string player)
        {
            if (cast.isValidCastMember(player))
            {
                Actor tempActor = cast.getCastMember(player);
                if (tempActor != null)
                {
                    boat.putInBoat(tempActor);
                    WriteLine($"{player} is in the boat");
                }
                else
                {
                    WriteLine($"Don't know who {player} is...");
                }
            }
        }

        public bool putInBoat(string player, out string message)
        {
            if (cast.isValidCastMember(player))
            {
                Actor tempActor = cast.getCastMember(player);
                if (tempActor == null)
                {
                    message = $"Don't know who {player} is...";
                    return false;
                }
                else if(tempActor.bank != boat.Side)
                {
                    message = $"{player} is on the {tempActor.bank} bank and the boat is on the {boat.Side} bank";
                    return false;
                }
                else{
                    boat.putInBoat(tempActor);
                    message = $"{player} is in the boat";
                    return true;
                }
            }
            message = $"ERROR! no such player <{player}>";
            return false;
        }

        public Bank whereIsBoat()
        {
            return boat.Side;
        }

        public void nextTurn()
        {
            boat.crossTheRiver();
            cast.updatePosition("farmer");
        }

        public string getBoatOccupant()
        {
            return boat.getBoatOccupant();
        }

        public String crossRiver()
        {
            boat.crossTheRiver();
            cast.updatePosition("farmer");
            return boat.reportOnPosition();
        }

        public Boolean safetyCheck()
        {
            return cast.everyoneSafe();
        }
    }
}