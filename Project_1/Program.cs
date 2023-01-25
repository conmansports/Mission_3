using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameIsGoing = true;
            int currTurn = 0;
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            char[] arrayGameBoard = { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

            do
            {
                char currTeam = ' ';
                if (currTurn % 2 == 0)
                {
                    currTeam = 'X';
                    Console.WriteLine("It's X's turn!");
                }
                else
                {
                    currTeam = 'O';
                    Console.WriteLine("It's O's turn!");
                }

                Console.WriteLine("Which square would you like to choose?");
                char userchoice = char.Parse(Console.ReadLine());
                bool goodAnswer = false;
                for (int i = 0; i < GameBoard.Length; i++)
                {
                    if (arrayGameBoard[i] == userchoice)
                    {
                        arrayGameBoard[i] = currTeam;
                        goodAnswer = true;
                        break;
                    }
                }
                if (goodAnswer)
                {
                    Supporting_Class();
                }
                else if (!goodAnswer)
                {
                    Console.WriteLine("This square has already been taken. Please choose a different square.");
                    currTurn--;
                }
                currTurn++;
            } while (gameIsGoing);

        }
    }

    class Supporting_Class
    {
        static void Main(string[] args)
        {
            static void GameBoard(Program d)
            {
                d.arrayGameBoard;
            }

            static void PrintBoard()
            {
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}|  {1}|  {2}", GameBoard[0], GameBoard[1], GameBoard[2]);
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}|  {1}|  {2}", GameBoard[3], GameBoard[4], GameBoard[5]);
                Console.WriteLine("_____|_____|_____");
                Console.WriteLine("     |     |     ");
                Console.WriteLine("  {0}|  {1}|  {2}", GameBoard[6], GameBoard[7], GameBoard[8]);
                Console.WriteLine("     |     |     ");
            }
            static void CheckWinner()
            {
                // Check for a horizontal win
                if (GameBoard[0] == GameBoard[1] && GameBoard[1] == GameBoard[2])
                {
                    if (GameBoard[0] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[0] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                    return;
                }
                else if (GameBoard[3] == GameBoard[4] && GameBoard[4] == GameBoard[5])
                {
                    if (GameBoard[3] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[3] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                    return;
                }
                else if (GameBoard[6] == GameBoard[7] && GameBoard[7] == GameBoard[8])
                {
                    if (GameBoard[6] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[6] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                    return;
                }

                // Check for a vertical win
                else if (GameBoard[0] == GameBoard[3] && GameBoard[3] == GameBoard[6])
                {
                    if (GameBoard[0] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[0] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                    return;
                }
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
                    return;
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
                    return;
                }

                // Check for a diagnol win
                else if (GameBoard[0] == GameBoard[4] && GameBoard[4] == GameBoard[8])
                {
                    if (GameBoard[0] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[0] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                    return;
                }
                else if (GameBoard[2] == GameBoard[4] && GameBoard[4] == GameBoard[6])
                {
                    if (GameBoard[2] == 'X')
                    {
                        Console.WriteLine("You won!! Congrats Player 1");
                    }
                    else if (GameBoard[2] == 'O')
                    {
                        Console.WriteLine("You won!! Congrats Player 2");
                    }
                    return;
                }

                // Check for a draw
                else if (GameBoard[0] != '0' && GameBoard[1] != '1' && GameBoard[2] != '2' && GameBoard[3] != '3' && GameBoard[4] != '4' && GameBoard[5] != '5' && GameBoard[6] != '6' && GameBoard[7] != '7' && GameBoard[8] != '8')
                {
                    Console.WriteLine("Its a draw, Try again");
                    return;
                }
            }
        }
        Program();
    }
}
