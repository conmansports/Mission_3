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
                    if (GameBoard[1] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[1] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                }
                else if (GameBoard[4] == GameBoard[5] && GameBoard[5] == GameBoard[6])
                {
                    if (GameBoard[4] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[4] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                }
                else if (GameBoard[7] == GameBoard[8] && GameBoard[8] == GameBoard[9])
                {
                    if (GameBoard[7] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[7] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                }

                // Check for a vertical win
                else if (GameBoard[1] == GameBoard[4] && GameBoard[4] == GameBoard[7])
                {
                    if (GameBoard[1] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[1] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                }
                else if (GameBoard[2] == GameBoard[5] && GameBoard[5] == GameBoard[8])
                {
                    if (GameBoard[2] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[2] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                }
                else if (GameBoard[3] == GameBoard[6] && GameBoard[6] == GameBoard[9])
                {
                    if (GameBoard[3] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[3] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                }

                // Check for a diagnol win
                else if (GameBoard[1] == GameBoard[5] && GameBoard[5] == GameBoard[9])
                {
                    if (GameBoard[1] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[1] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                }
                else if (GameBoard[3] == GameBoard[5] && GameBoard[5] == GameBoard[7])
                {
                    if (GameBoard[3] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[3] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
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
