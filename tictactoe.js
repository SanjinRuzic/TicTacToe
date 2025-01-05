class TicTacToe {
    constructor() {
        this.grid = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
        this.currentPlayer = 1;
        this.isGameActive = true;
        this.numTurns = 0;
        this.player1Score = 0;
        this.player2Score = 0;
    }

    showScore() {
        console.log(`\nScore - Player X: ${this.player1Score} | Player O: ${this.player2Score}\n`);
    }

    printGrid() {
        this.showScore();
        for (let i = 0; i < this.grid.length; i++) {
            process.stdout.write(` ${this.grid[i]} `);

            if ((i + 1) % 3 === 0) {
                console.log();
                if (i < 6) {
                    console.log("---|---|---");
                }
            } else {
                process.stdout.write("|");
            }
        }
    }

    makeMove(input) {
        const choice = parseInt(input);
        if (choice >= 1 && choice <= 9 && this.grid[choice - 1] !== "X" && this.grid[choice - 1] !== "O") {
            this.grid[choice - 1] = this.currentPlayer === 1 ? "X" : "O";
            return true; // Geçerli hamle
        } else {
            console.log(`Invalid move! Cell ${choice} is already taken or invalid. Please choose another cell.`);
            return false; // Geçersiz hamle
        }
    }

    checkWinDraw() {
        const winConditions = [
            [0, 1, 2], [3, 4, 5], [6, 7, 8], // Rows
            [0, 3, 6], [1, 4, 7], [2, 5, 8], // Columns
            [0, 4, 8], [2, 4, 6]             // Diagonals
        ];

        return winConditions.some(condition => {
            const [a, b, c] = condition;
            return this.grid[a] === this.grid[b] && this.grid[b] === this.grid[c];
        });
    }

    resetGame() {
        this.grid = ["1", "2", "3", "4", "5", "6", "7", "8", "9"];
        this.currentPlayer = 1;
        this.numTurns = 0;
        this.isGameActive = true;
    }

    updateScore() {
        if (this.currentPlayer === 1) {
            this.player1Score++;
        } else {
            this.player2Score++;
        }
    }

    play() {
        console.log("Welcome to 3x3 TicTacToe!");
        console.log("To make a move, enter the number corresponding to the cell where you want to place your symbol.");
        console.log("Player 1: X, Player 2: O\n");

        while (this.isGameActive && this.numTurns < 9) {
            console.log();
            this.printGrid();
            console.log();

            const input = prompt(`Player ${this.currentPlayer}, enter your move: `);
            const moveSuccessful = this.makeMove(input); // Hamle sonucunu kontrol et

            if (moveSuccessful) {
                if (this.checkWinDraw()) {
                    this.updateScore();
                    this.printGrid();
                    console.log();
                    console.log(`Congratulations, Player ${this.currentPlayer} wins! Thanks for playing 🎉`);
                    console.log();
                    this.isGameActive = false;
                } else {
                    this.currentPlayer = this.currentPlayer === 1 ? 2 : 1; // Sadece geçerli hamlede oyuncu değişir
                    this.numTurns++;
                }
            }

            if (this.numTurns === 9 && this.isGameActive) {
                this.printGrid();
                console.log();
                console.log("It's a draw! 🤝 Thanks for playing.");
                console.log();
                this.isGameActive = false;
            }
        }

        this.showScore();
        console.log("Game over!");
        const playAgain = prompt("Would you like to play again? (y/n): ").toLowerCase();
        if (playAgain === "y") {
            this.resetGame();
            this.play();
        } else {
            this.isGameActive = false;
            this.showScore();
            console.log("\nThanks for playing! Goodbye!");
        }
    }
}

// Oyunu başlat
const game = new TicTacToe();
const playGame = prompt("Would you like to play TicTacToe? (y/n): ").toLowerCase();
if (playGame === "y") {
    game.play();
} else {
    console.log("Maybe next time, goodbye!");
}
