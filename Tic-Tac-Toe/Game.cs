using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Game
    {
        private int maxTurns = 9;
        private bool win = false; 

        public void NewGame()
        {
            //clear board matrix
            Board gameBoard = new Board();
            gameBoard.ClearBoard();

            //create players
            Player player1 = new Player(); 
            Player player2 = new Player();

            player1.playerMarker = "X";
            player2.playerMarker = "O";
            string space; 

            //player turn
            for (int round = 0; round < maxTurns/2; round++)
            {
                if(win == false)
                {
                    space = player1.Turn();
                    //add to board
                    gameBoard.AddMarker(space, player1.playerMarker);
                    //display board
                    gameBoard.DisplayBoard();
                    //checkwin
                    win = gameBoard.CheckWin(player1.playerMarker);
                    if(win == true)
                    {
                        Console.WriteLine("GameOver"); 
                        return; 
                    }
                    space = player2.Turn();
                    //add to board
                    gameBoard.AddMarker(space, player2.playerMarker);
                    //display board
                    gameBoard.DisplayBoard();
                    //checkwin
                    win = gameBoard.CheckWin(player2.playerMarker);

                }
                else
                {
                    Console.WriteLine("Gameover");
                }
                
         
            }

        }



    }
}
