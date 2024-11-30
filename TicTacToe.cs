using System;

public class TicTacToe
{
    private string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    private int currentPlayer = 1;
    private bool isGameActive = true;
    private int numTurns = 0;

    public void PrintGrid()
    {
        for (int i = 0; i < grid.Length; i++)
        {
            if (grid[i] == "X")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (grid[i] == "O")
                Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write(" {0} ", grid[i]);
            Console.ResetColor();

            if ((i + 1) % 3 == 0)
            {
                Console.WriteLine();
                if (i < 6)
                {
                    Console.WriteLine("---|---|---");
                }
            }
            else
            {
                Console.Write("|");
            }
        }
        Console.ResetColor();
    }

    public void MakeMove(string input)
    {
        if (input.Length == 1 && char.IsDigit(input[0]) && int.Parse(input) >= 1 && int.Parse(input) <= 9)
        {
            int choice = int.Parse(input);
            if (grid[choice - 1] != "X" && grid[choice - 1] != "O")
            {
                grid[choice - 1] = currentPlayer == 1 ? "X" : "O";
            }
            else
            {
                Console.WriteLine("That cell is already occupied. Please choose another cell.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
        }
    }

    public bool CheckWinDraw()
    {
        bool row1_win = grid[0] == grid[1] && grid[1] == grid[2];
        bool row2_win = grid[3] == grid[4] && grid[4] == grid[5];
        bool row3_win = grid[6] == grid[7] && grid[7] == grid[8];
        bool col1_win = grid[0] == grid[3] && grid[3] == grid[6];
        bool col2_win = grid[1] == grid[4] && grid[4] == grid[7];
        bool col3_win = grid[2] == grid[5] && grid[5] == grid[8];
        bool diag1_win = grid[0] == grid[4] && grid[4] == grid[8];
        bool diag2_win = grid[6] == grid[4] && grid[4] == grid[2];

        return row1_win || row2_win || row3_win || col1_win || col2_win || col3_win || diag1_win || diag2_win;
    }

    public void ResetGame()
    {
        grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        currentPlayer = 1;
        numTurns = 0;
        isGameActive = true;
    }

    public void Play()
    {
        Console.WriteLine("Welcome to 3x3 TicTacToe!");
        Console.WriteLine("To make a move, enter the number corresponding to the cell where you want to place your symbol.");
        Console.WriteLine("Player 1: X, Player 2: O");
        Console.WriteLine();

        while (isGameActive && numTurns < 9)
        {
            Console.WriteLine();
            PrintGrid();
            Console.WriteLine();

            Console.Write($"Player {currentPlayer}, enter your move: ");
            string input = Console.ReadLine();
            MakeMove(input);

            if (CheckWinDraw())
            {
                PrintGrid();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulations, Player {currentPlayer} wins! Thanks for playing 🎉");
                Console.ResetColor();
                Console.WriteLine();
                isGameActive = false;
            }
            else
            {
                currentPlayer = currentPlayer == 1 ? 2 : 1;
                numTurns++;
            }

            if (numTurns == 9 && isGameActive)
            {
                PrintGrid();
                Console.WriteLine();
                Console.WriteLine("It's a draw! 🤝 Thanks for playing.");
                Console.WriteLine();
                isGameActive = false;
            }
        }

        PrintGrid();
        Console.WriteLine();
        Console.WriteLine("Game over!");
        Console.WriteLine("Would you like to play again? (y/n)");
        if (Console.ReadLine().ToLower() == "y")
        {
            ResetGame();
            Play();
        }
        else
        {
            isGameActive = false;
            Console.WriteLine("Maybe next time! Goodbye!");
        }
    }

    public static void Main(string[] args)
    {
        TicTacToe game = new TicTacToe();
        Console.WriteLine("Would you like to play TicTacToe? (y/n)");
        if (Console.ReadLine().ToLower() == "y")
        {
            game.Play();
        }
        else
        {
            Console.WriteLine("Maybe next time, goodbye!");
        }
    }
}
