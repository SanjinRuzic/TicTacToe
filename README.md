<a id="readme-top"></a>

[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]

<br />
<div align="center">
  <a href="https://github.com/othneildrew/Best-README-Template">
    <img src="images/logo.png" alt="Logo" width="80" height="80">
  </a>

  <h3 align="center">Tic-Tac-Toe Game</h3>

  <p align="center">
    A TicTacToe game developed in Python, JavaScript and C# as a collaborative software team project for the CS305 course.
    <br />
    <a href="https://github.com/othneildrew/Best-README-Template">View Demo</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues/new?labels=bug&template=bug-report---.md">Report Bug</a>
    ·
    <a href="https://github.com/othneildrew/Best-README-Template/issues/new?labels=enhancement&template=feature-request---.md">Request Feature</a>
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
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#team-members">Team Members</a></li>
    <li><a href="#license">License</a></li>
  </ol>
</details>


<!-- ABOUT THE PROJECT -->
## About The Project

Tic-Tac-Toe is a two-player game in which players take turns marking spaces on a 3x3 grid, with the objective being to align three of their markers in a row, column or diagonal. The project reimagines this classic game experience with a Python, JavaScript and C# console-based implementation. Our aim is not only to deliver a faithful rendition of the classic game experience but also to explore different language features and programming methodologies each language offers, and in creating these comparisons broaden our overall understanding and sharpen our software development skills in these technologies.

<p align="right">(<a href="#readme-top">back to top</a>)</p>


### Built With
* [![Python][python-shield]][python-url]
* [![JavaScript][javascript-shield]][javascript-url]
* [![C#][csharp-shield]][csharp-url]
<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Features
<h2>Inputs</h2>
<ul>
  <li><strong>User Input:</strong> The two players can make moves by providing a number from 1 to 9 corresponding to the cell they wish to place their marker (X or O) on the 3x3 grid. This input is only taken in the form of a number, and the program checks whether the selected position is available. Each move the player will be prompted to select a number for their move until a win or draw occurs.
The grid is updated after each turn to display the current state of the board. Players may not place a marker in any cell that is already previously occupied. Similarly, if the game ends, then no players are allowed to make any more moves.</li>
 <h2>Outputs</h2>
<ul>
<li><strong>Game Grid:</strong> After each move, the current game state is displayed as a 3x3 grid showing the position of 'X' and 'O'. Here is an example of such output:</li>
<pre>
X | O | 3
---------
4 | X | 6
---------
7 | 8 | O
</pre>
<li><strong>Win Condition:</strong></li>
A player wins in the event that three of their markers (either X or O), align in a column, row or diagonal. Our application will then announce the winner along with displaying a congratulatory message such as "Player X wins!" or "Player O wins!"</li>
<li><strong>Draw Condition:</strong></li>
The game is a draw if all cells are filled and no player has managed to align their three markers. In that instance, a message such as "It's a draw!" will be displayed.</li>
<li><strong>Game Reset:</strong></li>
After a win or draw, the game can be reset, clearing the board and starting a new round.</li>
</ul>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- GETTING STARTED -->
## Getting Started

This is an example of how you may give instructions on setting up your project locally.
To get a local copy up and running follow these simple example steps.

### Prerequisites

This is an example of how to list things you need to use the software and how to install them.
* npm
  ```sh
  npm install npm@latest -g
  ```

### Installation

_Below is an example of how you can instruct your audience on installing and setting up your app. This template doesn't rely on any external dependencies or services._

1. Get a free API Key at [https://example.com](https://example.com)
2. Clone the repo
   ```sh
   git clone https://github.com/github_username/repo_name.git
   ```
3. Install NPM packages
   ```sh
   npm install
   ```
4. Enter your API in `config.js`
   ```js
   const API_KEY = 'ENTER YOUR API';
   ```
5. Change git remote url to avoid accidental pushes to base project
   ```sh
   git remote set-url origin github_username/repo_name
   git remote -v # confirm the changes
   ```

<p align="right">(<a href="#readme-top">back to top</a>)</p>

## Team Members

<ul>
  <li>Cem Berke Tepedelen</li>
  <li>Muhammed Said Sincar</li>
  <li>Sanjin Ružić</li>
</ul>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
[python-shield]: https://img.shields.io/badge/Python-3776AB?style=for-the-badge&logo=python&logoColor=white
[python-url]: https://www.python.org/
[javascript-shield]: https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black
[JavaScript-url]: https://developer.mozilla.org/en-US/docs/Web/JavaScript
[csharp-shield]: https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white
[csharp-url]: https://learn.microsoft.com/en-us/dotnet/csharp/

