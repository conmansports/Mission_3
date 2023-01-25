
using System;
namespace Project_1
{
    class Driver
    {
        static void Main(string[] args)
        {
            bool gameIsGoing = true;
            int currTurn = 0;
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            char[] GameBoard = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            // Print board for first time
            Supporting_Class.PrintBoard(GameBoard);
            do
            {
                // Switches turns
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
                    // Checks to see if the space is empty
                    if (GameBoard[i] == userchoice)
                    {
                        GameBoard[i] = currTeam;
                        goodAnswer = true;
                        break;
                    }
                }
                if (goodAnswer)
                {
                    // if the answer is good, print the board and check if its a win
                    Supporting_Class.PrintBoard(GameBoard);
                    if (Supporting_Class.CheckWinner(GameBoard))
                    {
                        Console.WriteLine("Thank you for playing!");
                        gameIsGoing = false;
                    }
                }
                else if (!goodAnswer)
                {
                    // if spot is taken, say so
                    Supporting_Class.PrintBoard(GameBoard);
                    Console.WriteLine("This square has already been taken. Please choose a different square.");
                    currTurn--;
                }
                currTurn++;
                // only play while game is going
            } while (gameIsGoing);
        }
    }
    class Supporting_Class
    {
        public static void PrintBoard(char[] GameBoard)
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[0], GameBoard[1], GameBoard[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[3], GameBoard[4], GameBoard[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", GameBoard[6], GameBoard[7], GameBoard[8]);
            Console.WriteLine("     |     |     ");
        }
        public static bool CheckWinner(char[] GameBoard)
        {
            // Check for a horizontal win
            if (GameBoard[0] == GameBoard[1] && GameBoard[1] == GameBoard[2])
            {
                if (GameBoard[0] == 'X')
                {
                    Console.WriteLine("You won!! Congrats Player 1");
                    return true;
                }
                else if (GameBoard[0] == 'O')
                {
                    Console.WriteLine("You won!! Congrats Player 2");
                    return true;
                }
            }
            else if (GameBoard[3] == GameBoard[4] && GameBoard[4] == GameBoard[5])
            {
                if (GameBoard[3] == 'X')
                {
                    Console.WriteLine("You won!! Congrats Player 1");
                    return true;
                }
                else if (GameBoard[3] == 'O')
                {
                    Console.WriteLine("You won!! Congrats Player 2");
                    return true;
                }
            }
            else if (GameBoard[6] == GameBoard[7] && GameBoard[7] == GameBoard[8])
            {
                if (GameBoard[6] == 'X')
                {
                    Console.WriteLine("You won!! Congrats Player 1");
                    return true;
                }
                else if (GameBoard[6] == 'O')
                {
                    Console.WriteLine("You won!! Congrats Player 2");
                    return true;
                }
            }
            // Check for a vertical win
            else if (GameBoard[0] == GameBoard[3] && GameBoard[3] == GameBoard[6])
            {
                if (GameBoard[0] == 'X')
                {
                    Console.WriteLine("You won!! Congrats Player 1");
                    return true;
                }
                else if (GameBoard[0] == 'O')
                {
                    Console.WriteLine("You won!! Congrats Player 2");
                    return true;
                }
            }
            else if (GameBoard[1] == GameBoard[4] && GameBoard[4] == GameBoard[7])
            {
                if (GameBoard[1] == 'X')
                {
                    Console.WriteLine("You won!! Congrats Player 1");
                    return true;
                }
                else if (GameBoard[1] == 'O')
                {
                    Console.WriteLine("You won!! Congrats Player 2");
                    return true;
                }
            }
            else if (GameBoard[2] == GameBoard[5] && GameBoard[5] == GameBoard[8])
            {
                if (GameBoard[2] == 'X')
                {
                    Console.WriteLine("You won!! Congrats Player 1");
                    return true;
                }
                else if (GameBoard[2] == 'O')
                {
                    Console.WriteLine("You won!! Congrats Player 2");
                    return true;
                }
            }
            // Check for a diagnol win
            else if (GameBoard[0] == GameBoard[4] && GameBoard[4] == GameBoard[8])
            {
                if (GameBoard[0] == 'X')
                {
                    Console.WriteLine("You won!! Congrats Player 1");
                    return true;
                }
                else if (GameBoard[0] == 'O')
                {
                    Console.WriteLine("You won!! Congrats Player 2");
                    return true;
                }
            }
            else if (GameBoard[2] == GameBoard[4] && GameBoard[4] == GameBoard[6])
            {
                if (GameBoard[2] == 'X')
                {
                    Console.WriteLine("You won!! Congrats Player 1");
                    return true;
                }
                else if (GameBoard[2] == 'O')
                {
                    Console.WriteLine("You won!! Congrats Player 2");
                    return true;
                }
            }
            // Check for a draw
            else if (GameBoard[0] != '1' && GameBoard[1] != '2' && GameBoard[2] != '3' && GameBoard[3] != '4' && GameBoard[4] != '5' && GameBoard[5] != '6' && GameBoard[6] != '7' && GameBoard[7] != '8' && GameBoard[8] != '9')
            {
                Console.WriteLine("Its a draw, Try again");
                return true;
            }
            return false;
        }
    }
}
