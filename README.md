
## What is Knights Tour?

![alt text](https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Knight%27s_tour_anim_2.gif/375px-Knight%27s_tour_anim_2.gif)

A knight's tour is a sequence of moves of a knight on a chessboard such that the knight visits every square only once. If the knight ends on a square that is one knight's move from the beginning square (so that it could tour the board again immediately, following the same path), the tour is closed, otherwise it is open.

The knight's tour problem is the mathematical problem of finding a knight's tour. Creating a program to find a knight's tour is a common problem given to computer science students.[1] Variations of the knight's tour problem involve chessboards of different sizes than the usual 8 × 8, as well as irregular (non-rectangular) boards.

https://en.wikipedia.org/wiki/Knight%27s_tour

## What this program does:
In this program the Knight starts on a random (x and y) position on the chess board.  The user can select a huristic method or a non huristic method.  

In the heuristic method the multi-dimensional chess board is mapped using the following pattern:
![alt text](https://upload.wikimedia.org/wikipedia/commons/thumb/6/64/Knight%27s_graph_showing_number_of_possible_moves.svg/405px-Knight%27s_graph_showing_number_of_possible_moves.svg.png)

For the Knight it is easier to traverse the inner board with where all the 8 squares are located (without getting stuck).  So it starts from the outside boundary lower numbers and tries to move in on the higher numbers.

For the non heuristic method, the Knight simply tries to traverse the chess board without any pattern, therefore it can get stuck at any time 

The movement of the knight is computed using x and y and the following formula (it can move as long it is in the chess board):
x + 2, y + 1
x - 2, y - 1
x - 2, y + 1
x - 2, y - 1
x + 1, y + 2
x - 1, y - 2
x - 1, y + 2
x - 1, y - 2

![alt text](https://i.imgur.com/kbcAeDA.png)
![alt text](https://i.imgur.com/IriQuXS.png)
![alt text](https://i.imgur.com/7pC10JD.png)
![alt text](https://i.imgur.com/VL5ybhe.png)

