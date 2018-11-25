using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Board
    {
        public string[,] board = new string[3, 3] { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
        


        public void DisplayBoard()
        {

            for(int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    if(col < 2)
                    {
                        Console.Write("|"); 
                    }


                }

                Console.WriteLine();
                if(row < 2)
                {
                    Console.WriteLine("-+-+-"); 
                }
            }
            
        }

        public void ClearBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = " "; 
                }
            }
        }

        public void AddMarker(string space, string marker)
        {
            switch (space)
            {
                case "1":
                    board[0, 0] = marker;
                    break;
                case "2":
                    board[0, 1] = marker;
                    break;
                case "3":
                    board[0, 2] = marker;
                    break;
                case "4":
                    board[1, 0] = marker;
                    break;
                case "5":
                    board[1, 1] = marker;
                    break;
                case "6":
                    board[1, 2] = marker;
                    break;
                case "7":
                    board[2, 0] = marker;
                    break;
                case "8":
                    board[2, 1] = marker;
                    break;
                case "9":
                    board[2, 2] = marker;
                    break;
            }
        }

        public bool CheckWin(string marker)
        {

            for (int row = 0; row < 3; row++)
            {

                if
                    (
                        board[row, 0] == marker &&
                        board[row, 1] == marker &&
                        board[row, 2] == marker
                    )
                {
                    return true;
                }
            }

            for (int col = 0; col < 3; col++)
            {

                if
                    (
                        board[0, col] == marker &&
                        board[1, col] == marker &&
                        board[2, col] == marker
                    )
                {
                    return true;
                }
            }

            if
                (
                    board[0, 0] == marker &&
                    board[1, 1] == marker &&
                    board[2, 2] == marker
                )
            {
                return true;
            }

            if
                (
                    board[2, 0] == marker &&
                    board[1, 1] == marker &&
                    board[0, 2] == marker
                )
            {
                return true;
            }

            return false;

        }
    }
}
