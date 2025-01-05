import os
 
def clear_console():
    os.system('cls' if os.name == 'nt' else 'clear')
 
def print_grid(grid, player1_score, player2_score):
    print(f"\nScore: {player1_score} - {player2_score}\n")
    for i in range(9):
        cell = grid[i]
        if cell == "X":
            print(f" \033[91m{cell}\033[0m ", end="")  # Red for X
        elif cell == "O":
            print(f" \033[94m{cell}\033[0m ", end="")  # Blue for O
        else:
            print(f" {cell} ", end="")
        if (i + 1) % 3 == 0:
            print()
            if i < 6:
                print("---|---|---")
        else:
            print("|", end="")
 
def check_win(grid):
    win_combinations = [
        [0, 1, 2], [3, 4, 5], [6, 7, 8],  # Rows
        [0, 3, 6], [1, 4, 7], [2, 5, 8],  # Columns
        [0, 4, 8], [2, 4, 6]              # Diagonals
    ]
    for combo in win_combinations:
        if grid[combo[0]] == grid[combo[1]] == grid[combo[2]]:
            return True
    return False
 
def reset_game():
    return [str(i + 1) for i in range(9)]
 
def play():
    grid = reset_game()
    current_player = 1
    is_game_active = True
    num_turns = 0
    player1_score = 0
    player2_score = 0
 
    print("Welcome to 3x3 TicTacToe!")
    print("To make a move, enter the number corresponding to the cell where you want to place your symbol.")
    print("Player 1: X, Player 2: O\n")
 
    while True:
        clear_console()
        print_grid(grid, player1_score, player2_score)
        print()
 
        if not is_game_active:
            print("Would you like to play again? (y/n)")
            if input().lower() == "y":
                grid = reset_game()
                current_player = 1
                num_turns = 0
                is_game_active = True
                continue
            else:
                print("\nThanks for playing! Goodbye!")
                break
 
        print(f"Player {current_player}, enter your move: ", end="")
        move = input()
 
        if move.isdigit() and 1 <= int(move) <= 9:
            choice = int(move) - 1
            if grid[choice] not in ["X", "O"]:
                grid[choice] = "X" if current_player == 1 else "O"
                num_turns += 1
 
                if check_win(grid):
                    clear_console()
                    print_grid(grid, player1_score, player2_score)
                    print()
                    print(f"\033[92mCongratulations, Player {current_player} wins this round!\033[0m")
                    if current_player == 1:
                        player1_score += 1
                    else:
                        player2_score += 1
                    print(f"\033[93mCurrent Score - Player X: {player1_score}, Player O: {player2_score}\033[0m")
                    input("Press Enter to continue...")
                    is_game_active = False
                elif num_turns == 9:
                    clear_console()
                    print_grid(grid, player1_score, player2_score)
                    print()
                    print("It's a draw! 🤝")
                    is_game_active = False
                else:
                    current_player = 1 if current_player == 2 else 2
            else:
                print("\n\033[91mError: You cannot place your symbol on an already occupied cell!\033[0m")
                input("Press Enter to continue...")
        else:
            print("Invalid input! Please enter a number between 1 and 9.")
 
if __name__ == "__main__":
    print("Would you like to play TicTacToe? (y/n)")
    if input().lower() == "y":
        play()
    else:
        print("Maybe next time, goodbye!")