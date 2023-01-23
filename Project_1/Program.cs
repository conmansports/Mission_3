using System;

namespace Project_1
{
    class Supporting_Class
    {
        static void Main(string[] args)
        {
            static void GameBoard(Driver d)
            {
                d.arrayGameBoard;
            }
            static void PrintBoard()
            {
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}|  {1}|  {2}", GameBoard[1], GameBoard[2], GameBoard[3]);
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}|  {1}|  {2}", GameBoard[4], GameBoard[5], GameBoard[6]);
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}|  {1}|  {2}", GameBoard[7], GameBoard[8], GameBoard[9]);
                Console.WriteLine("     |     |     ");
            }
            static void CheckWinner()
            {
                // Check for a horizontal win
                if (GameBoard[1] == GameBoard[2] && GameBoard[2] == GameBoard[3])
                {
                    Console.WriteLine("You won!! Congrats");
                }
                else if (GameBoard[4] == GameBoard[5] && GameBoard[5] == GameBoard[6])
                {
                    Console.WriteLine("You won!! Congrats");
                }
                else if (GameBoard[7] == GameBoard[8] && GameBoard[8] == GameBoard[9])
                {
                    Console.WriteLine("You won!! Congrats")
                }

                // Check for a vertical win
                else if (GameBoard[1] == GameBoard[4] && GameBoard[4] == GameBoard[7])
                {
                    Console.WriteLine("You won!! Congrats");
                }
                else if (GameBoard[2] == GameBoard[5] && GameBoard[5] == GameBoard[8])
                {
                    Console.WriteLine("You won!! Congrats");
                }
                else if (GameBoard[3] == GameBoard[6] && GameBoard[6] == GameBoard[9])
                {
                    Console.WriteLine("You won!! Congrats")
                }

                // Check for a diagnol win
                else if (GameBoard[1] == GameBoard[5] && GameBoard[5] == GameBoard[9])
                {
                    Console.WriteLine("You won!! Congrats");
                }
                else if (GameBoard[3] == GameBoard[5] && GameBoard[5] == GameBoard[7])
                {
                    Console.WriteLine("You won!! Congrats")
                }

                // Check for a draw
                else if (GameBoard[1] != '1' && GameBoard[2] != '2' && GameBoard[3] != '3' && GameBoard[4] != '4' && GameBoard[5] != '5' && GameBoard[6] != '6' && GameBoard[7] != '7' && GameBoard[8] != '8' && GameBoard[9) != '9'
                {
                    Console.WriteLine("Its a draw, Try again");
                }
            }
        }
    }
}
