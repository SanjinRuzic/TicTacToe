using System;

public class TicTacToe
{
    public static void PrintGrid(string[] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            Console.Write(" {0} ", grid[i]);

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
    }

    public static void Main(string[] args)
    {
        string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        int currentPlayer = 1;
        bool isGameActive = true;

        Console.WriteLine("Welcome to 3x3 TicTacToe!");
        Console.WriteLine("To make a move, enter the number corresponding to the cell where you want to place your symbol.");
        Console.WriteLine("Player 1: X, Player 2: O");
        Console.WriteLine();

        while (isGameActive)
        {
            Console.WriteLine();
            PrintGrid(grid);
            Console.WriteLine();

            Console.Write($"Player {currentPlayer}, enter your move: ");
            string input = Console.ReadLine();

            if (input.Length == 1 && char.IsDigit(input[0]) && int.Parse(input) >= 1 && int.Parse(input) <= 9)
            {
                int choice = int.Parse(input);

                if (grid[choice - 1] != "X" && grid[choice - 1] != "O")
                {
                    grid[choice - 1] = currentPlayer == 1 ? "X" : "O";
                    currentPlayer = currentPlayer == 1 ? 2 : 1;
                }
                else
                {
                    Console.WriteLine("Please choose a cell that is not already taken.");
                }
            }
            else
            {
                Console.WriteLine("Invalid move! Please enter a number between 1 and 9 for a cell that is not already taken.");
            }
        }
    }
}
