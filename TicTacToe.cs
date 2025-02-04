﻿using System;

public class TicTacToe
{
    private string[] grid = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    private int currentPlayer = 1;
    private bool isGameActive = true;
    private int numTurns = 0;
    private int player1Score = 0;
    private int player2Score = 0;

    public void ShowScore()
    {
        Console.WriteLine($"\nScore: {player1Score} - {player2Score}\n");
    }

    public void PrintGrid()
    {
        ShowScore();
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

    public bool MakeMove(string input)
    {

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 9.");
            return false;
        }

        if (input.Length != 1 || !int.TryParse(input, out int choice) || choice < 1 || choice > 9)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
            return false;
        }

        if (grid[choice - 1] == "X" && grid[choice - 1] == "O")
        {
            Console.WriteLine("That cell is already occupied. Please choose another cell.");
            return false;
        }

        grid[choice - 1] = currentPlayer == 1 ? "X" : "O";
        return true;
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

    public void UpdateScore()
    {
        if (currentPlayer == 1)
            player1Score++;
        else
            player2Score++;
    }

    public void Play()
    {
        bool playAgain = true;
        while (playAgain)
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

                bool validMoveMade = false;
                while (!validMoveMade)
                {
                    Console.Write($"Player {currentPlayer}, enter your move: ");
                    string input = Console.ReadLine();
                    validMoveMade = MakeMove(input);
                }

                if (CheckWinDraw())
                {
                    UpdateScore();
                    PrintGrid();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations, Player {currentPlayer} wins! Thanks for playing");
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
                    Console.WriteLine("It's a draw! Thanks for playing.");
                    Console.WriteLine();
                    isGameActive = false;
                }
            }

            ShowScore();
            Console.WriteLine("Game over!");
            Console.WriteLine("Would you like to play again? (y/n)");
            string response = Console.ReadLine()?.ToLower() ?? "n";
            if (response == "y")
            {
                ResetGame();
            }
            else
            {
                playAgain = false;
                ShowScore();
                Console.WriteLine("\nThanks for playing! Goodbye!");
            }
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