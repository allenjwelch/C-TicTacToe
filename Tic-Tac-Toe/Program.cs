using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            GameStart();
            Console.ReadKey(); 
        }

        static void GameStart()
        {
            Console.WriteLine("--- Get Ready to Play! ---"); 
            Console.WriteLine("Below is your board layout. ");
            Console.WriteLine("On your turn, select the number of the space you want to play.");

            Board board = new Board();
            Game game = new Game(); 
            board.DisplayBoard();

            Console.Write("Are you ready to play? ");
            string userReady = Console.ReadLine(); 

            if(userReady == "yes")
            {
                Console.WriteLine("Ready Player 1..."); 
                game.NewGame(); 
            }
            else if (userReady == "no")
            {
                return; 
            }
            else
            {
                Console.WriteLine("Please enter a valid command (yes/no)");
                GameStart(); 
            }

        }
    }
}
