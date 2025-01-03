<a id="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<br />
<div align="center">
  <a href="https://github.com/SanjinRuzic/TicTacToe">
    <img src="https://m.media-amazon.com/images/I/411RqsooQ3L.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Tic-Tac-Toe Game</h3>

  <p align="center">
    A TicTacToe game developed in Python, JavaScript and C# as a collaborative software team project for the CS305 course.
    <br />
    <a href="https://github.com/SanjinRuzic/TicTacToe">View Demo</a>
    ·
    <a href="https://github.com/SanjinRuzic/TicTacToe/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    ·
    <a href="https://github.com/SanjinRuzic/TicTacToe/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
  </p>
</div>


<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
         <li><a href="#features">Features</a></li>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#team-members">Team Members</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>

## About The Project

Tic-Tac-Toe is a two-player game in which players take turns marking spaces on a 3x3 grid, with the objective being to align three of their markers in a row, column or diagonal. The project reimagines this classic game experience with a Python, JavaScript and C# console-based implementation. Our aim is not only to deliver a faithful rendition of Tic-Tac-Toe but also to explore different language features and programming methodologies each language offers, and in creating these comparisons broaden our overall understanding and sharpen our software development skills in these technologies.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Built With
* [![Python][python-shield]][python-url]
* [![JavaScript][javascript-shield]][javascript-url]
* [![C#][csharp-shield]][csharp-url]
<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Features
<h2>Inputs</h2>
In the game, each player takes turns to choose a number from 1 to 9 to place their marker (either X or O) on the 3x3 grid. The program accepts the input only in the form of a number, and checks whether the selected cell is still available. After each turn, the game board is updated to reflect the current state of the game. Players are not allowed to place a marker on a cell that is already occupied. Once the game ends, players are not allowed to make any more moves.
 <h2>Outputs</h2>
<ul>
<li><strong>Game Grid:</strong> After each move, the current game state is displayed as a 3x3 grid showing the position of 'X' and 'O'. Here is an example of such output:</li>
<pre>
1 | 2 | O
---|---|---
X | O | 6
---|---|---
X | 8 | X
</pre>
<li><strong>Win Condition:</strong></li>
A player wins should three of their markers (either X or O), align in a column, row or diagonal. Our application will then announce the winner along with displaying a congratulatory message such as "Player X wins!" or "Player O wins!"</li>
<li><strong>Draw Condition:</strong></li>
The game is a draw if all cells are filled and no player has managed to align their three markers. In that instance, a message such as "It's a draw!" will be displayed.</li>
<li><strong>Game Reset:</strong></li>
After a win or draw, the game can be reset, clearing the board and starting a new round.</li>
</ul>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

### Installation

<p>Follow these steps to set up and run the Tic-Tac-Toe project locally.</p>

<h2>Prerequisites</h2>
<p>Before proceeding, ensure that the following are properly installed and configured on your system, depending on the implementation:</p>
<ul>
<li><a href="https://www.python.org/downloads/" target="_blank">Python 3.x</a> must be installed.</li>
<li><a href="https://nodejs.org/" target="_blank">Node.js</a> must be installed.</li>
<li><a href="https://dotnet.microsoft.com/download" target="_blank">.NET SDK</a> must be installed.</li>
</ul>

<h2>Installation Steps</h2>
<ol>
<li><strong>Clone the repository:</strong>
<pre><code>git clone https://github.com/SanjinRuzic/TicTacToe.git</code></pre></li>
<li><strong>Navigate to the project directory:</strong>
<pre><code>cd TicTacToe/src</code></pre></li>
<li>
<strong>Run the application:</strong><p>Choose the implementation you want to run:</p>
<ul>
<li><strong>Python:</strong>
<pre><code>python TicTacToe.py</code></pre></li>
<li><strong>JavaScript:</strong>
<pre><code>node TicTacToe.js</code></pre></li>
<li><strong>C#:</strong>
<pre><code>dotnet run TicTacToe.cs</code></pre></li>
</ul>
</li>
</ol>

<ul>
<li>Verify that the required software (Python, Node.js, and .NET SDK) is properly installed and added to your system's PATH.</li>
</ul>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Team Members

<ul>
  <li>Cem Berke Tepedelen (JavaScript)</li>
  <li>Muhammed Said Sincar (Python)</li>
  <li>Sanjin Ružić (C#)</li>
</ul>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/SanjinRuzic/TicTacToe.svg?style=for-the-badge
[contributors-url]: https://github.com/SanjinRuzic/TicTacToe/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/SanjinRuzic/TicTacToe.svg?style=for-the-badge
[forks-url]: https://github.com/SanjinRuzic/TicTacToe/network/members
[stars-shield]: https://img.shields.io/github/stars/SanjinRuzic/TicTacToe.svg?style=for-the-badge
[stars-url]: https://github.com/SanjinRuzic/TicTacToe/stargazers
[issues-shield]: https://img.shields.io/github/issues/SanjinRuzic/TicTacToe.svg?style=for-the-badge
[issues-url]: https://github.com/SanjinRuzic/TicTacToe/issues
[license-shield]: https://img.shields.io/github/license/SanjinRuzic/TicTacToe.svg?style=for-the-badge
[license-url]: https://github.com/SanjinRuzic/TicTacToe/blob/master/LICENSE.txt
[python-shield]: https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python&logoColor=white
[python-url]: https://www.python.org/
[javascript-shield]: https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black
[javascript-url]: https://developer.mozilla.org/en-US/docs/Web/JavaScript
[csharp-shield]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white
[csharp-url]: https://learn.microsoft.com/en-us/dotnet/csharp/

