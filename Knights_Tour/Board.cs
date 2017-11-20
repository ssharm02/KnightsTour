using System;
using System.Collections.Generic;

namespace Knights_Tour
{
    class Board
    {
        /* The Board class represents a chess board made up of squares (using Square class). The
         * board has six attributes: a two dimensional matrix of Square objects to represent the
         * board, a Random object used to select random moves for the knight during the knight's
         * tour, an x and y value to represent the knight's coordinates on the grid, a value
         * representing the total number of moves made by the knight, and a list used to store
         * x y pairs, representing possible moves the knight can make.
         */

        // PARAMETERS
        private Square[,] grid = new Square[12, 12];  // grid represents the chess board
        private Random rand = new Random(); // selects random move from possible moves
        private int curr_x, curr_y;         // coordinates of knight on the board
        private int numMoves;           // total number of moves made by the knight
        private List<int[]> possibleMoves;  // list of possible coordinates knight can move to

        // CONSTRUCTOR
        public Board(bool smart)
        {
            /* When the board is constructed, each square on the grid is initialized. If the
             * boolean parameter is set to true, the board also sets priority values to map out a
             * heuristic priority matrix, for use during the knight's tour heuristic method.
             */
            for (int y = 0; y < 8; y++) // loop through each y coordinate
            {
                for (int x = 0; x < 8; x++) // loop through each x coordinate
                {
                    if (smart)  // initialize squares with heuristic mapping
                    {
                        if (y == 0 || y == 7)
                        {
                            if (x == 0 || x == 7)
                                grid[x, y] = new Square(2);
                            else if (x == 1 || x == 6)
                                grid[x, y] = new Square(3);
                            else
                                grid[x, y] = new Square(4);
                        }
                        else if (y == 1 || y == 6)
                        {
                            if (x == 0 || x == 7)
                                grid[x, y] = new Square(3);
                            else if (x == 1 || x == 6)
                                grid[x, y] = new Square(4);
                            else
                                grid[x, y] = new Square(6);
                        }
                        else
                        {
                            if (x == 0 || x == 7)
                                grid[x, y] = new Square(4);
                            else if (x == 1 || x == 6)
                                grid[x, y] = new Square(6);
                            else
                                grid[x, y] = new Square(8);
                        }
                    } // END heuristic initialization
                    else    // initialize squares normally
                    {
                        grid[x, y] = new Square();
                    } // END normal initialization
                } // END x loop
            } // END y loop
            //Console.Write(grid);
        } // END constructor Board(bool)

        // METHODS
        public void knightsTour(bool smart)
        {
            /* The knight's tour simulates a knight moving around a chess board. The knight may
             * not enter a square more than once, and the tour ends once there are no more moves
             * available. The non-intelligent method moves the knight randomly, whereas the smart
             * method uses a heuristic matrix (mapped to the grid during construction) to
             * prioritize moving to a square that has the least number of possible moves.
             */

            // set knight's initial position randomly
            curr_x = rand.Next(0, 7);
            curr_y = rand.Next(0, 7);
            moveKnight(curr_x, curr_y);
            // move knight around the board
            while (checkMoves()) // checks for available move(s)
            {
                if (smart)  // throw out all but highest priority moves
                {
                    prioritize();
                }
                // select random move from possible moves
                int index = rand.Next(0, (possibleMoves.Count - 1));
                int[] move = possibleMoves[index];
                // move the knight
                moveKnight(move[0], move[1]);
                // reset list of possible moves
                possibleMoves = null;
            } // no more moves are available
        } // END knightsTour(bool)

        private bool checkMoves()
        {
            /* The method checks each of eight possible moves the knight can make from its
             * current position. If a move would place the knight in a square it has already
             * entered, or off the board, the move is ignored. Otherwise, it is recorded to a
             * list of available moves. The method returns false if no possible moves were
             * found, otherwise it returns true.
             */

            // initialize list of possible moves
            possibleMoves = new List<int[]>();

            // cycle through each possible move
            if (curr_x + 2 <= 7)
            {
                if (curr_y + 1 <= 7)
                {
                    canMoveKnight(curr_x + 2, curr_y + 1);
                }
                if (curr_y - 1 >= 0)
                {
                    canMoveKnight(curr_x + 2, curr_y - 1);
                }
            }
            if (curr_x - 2 >= 0)
            {
                if (curr_y + 1 <= 7)
                {
                    canMoveKnight(curr_x - 2, curr_y + 1);
                }
                if (curr_y - 1 >= 0)
                {
                    canMoveKnight(curr_x - 2, curr_y - 1);
                }
            }
            if (curr_x + 1 <= 7)
            {
                if (curr_y + 2 <= 7)
                {
                    canMoveKnight(curr_x + 1, curr_y + 2);
                }
                if (curr_y - 2 >= 0)
                {
                    canMoveKnight(curr_x + 1, curr_y - 2);
                }
            }
            if (curr_x - 1 >= 0)
            {
                if (curr_y + 2 <= 7)
                {
                    canMoveKnight(curr_x - 1, curr_y + 2);
                }
                if (curr_y - 2 >= 0)
                {
                    canMoveKnight(curr_x - 1, curr_y - 2);
                }
            }
            // all moves have been checked
            if (possibleMoves.Count == 0)  // no available moves
            {
                return false;
            }
            // increment total number of moves
            numMoves++;
            return true;
        } // END checkMoves() -> bool

        private void moveKnight(int x, int y)
        {
            /* The knight is moved to the coordinate parameters.
             */

            // set new coordinates of knight
            curr_x = x;
            curr_y = y;
            // set the new square value
            grid[x, y].setValue(1 + numMoves);
        } // END moveKnight(int, int)

        private void canMoveKnight(int x, int y)
        {
            /* If the value of the square indicated by parameters is equal to zero, then the
             * knight has not moved to that square yet, and subsequently can move there on its
             * next turn. The move is added to a list of possible moves, which an actual move
             * will later be selected from.
             */

            if (grid[x, y].getValue() == 0)    // move is possible
            {
                // add move to list of possible moves
                int[] coord = { x, y };
                possibleMoves.Add(coord);
            }
        } // END canMoveKnight(int, int)

        private void prioritize()
        {
            /* The method loops through the list of available moves to find the highest
             * priority (highest being the lowest priority value). Then it throws out any move(s)
             * of lower priority.
             */

            // lowest priority is always eight
            int priority = 8;
            // find lowest priority
            foreach (int[] coord in possibleMoves)
            {
                if (grid[coord[0], coord[1]].getPriority() < priority)
                    priority = grid[coord[0], coord[1]].getPriority();
            } // END loop
            // throw out lower priority moves
            for (int i = 0; i < possibleMoves.Count; i++)
            {
                int[] coord = possibleMoves[i];
                if (grid[coord[0], coord[1]].getPriority() > priority)
                {
                    // move is lower priority - remove
                    possibleMoves.RemoveAt(i);
                    // decrement counter to reflect list resize
                    i--;
                }
            } // END loop
        } // END prioritize()

        public int getNumMoves()
        {
            return numMoves;
        } // END getNumMoves()

        public string toString()
        {
            /* The method returns a formatted string representation of the board, including the
             * value of each square if it has been modified from its original value of zero.
             */

            // declare formatted string
            string output;
            // string is formatted using special extended ASCII characters to look a bit nicer
            output = "╔════╦════╦════╦════╦════╦════╦════╦════╗\n";
            // loop through y coordinates
            for (int y = 0; y < 8; y++)
            {
                // loop through x coordinates
                for (int x = 0; x < 8; x++)
                {
                    int move = grid[x, y].getValue();
                    if (move == 0)
                    {
                        // square is empty
                        output = output + "║    ";
                    }
                    else
                    {
                        // square includes value representing turn the knight entered
                        output = output + "║ " + move.ToString("00") + " ";
                    }
                } // END x loop
                output = output + "║\n";
                if (y == 7)
                {
                    output = output + "╚════╩════╩════╩════╩════╩════╩════╩════╝";
                }
                else
                {
                    output = output + "╠════╬════╬════╬════╬════╬════╬════╬════╣\n";
                }
            } // END y loop
            return output;
        } // END toString()

    } // END class Board
}
