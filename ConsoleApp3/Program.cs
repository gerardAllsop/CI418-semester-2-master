using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxGooseCorn

{
    class Program
    {
        static void Main(string[] args)
        {
            //we'll create a Puzzle class object
            Puzzle puzzle = new Puzzle();
            string userResponse = "";
            bool repeat = true;

            //print out the intro txt
            puzzle.printIntro();
            puzzle.printAllPlayerPositions();
            while (repeat)
            {
                puzzle.printInstructions();
                userResponse = Console.ReadLine();
                Console.Clear();
                //rewrite as switch statement
                switch (userResponse)
                {
                    case "1":
                        puzzle.printIntro();
                        break;
                    case "2":
                        puzzle.printAllPlayerPositions();
                        break;
                    case "3":
                        puzzle.printAllPlayerPositions();
                        Console.Write("Player: ");
                        string player = Console.ReadLine();
                        puzzle.whereIsPlayer(player);
                        break;
                    case "4":
                        Console.Write("Put which Player in the boat: ");
                        player = Console.ReadLine();
                        puzzle.putInBoat(player);
                        break;
                    case "5":
                        puzzle.nextTurn();
                        break;
                    case "6":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a menu choice from 1..4");
                        break;
                }
            }
        }
    }
}
