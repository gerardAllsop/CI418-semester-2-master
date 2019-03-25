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

        public void nextTurn()
        {
            boat.crossTheRiver();
            cast.updatePosition("farmer");
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