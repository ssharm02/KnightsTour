namespace Knights_Tour
{
    class Square
    {
        /* The Square class represents an individual square on a chess board. Each square has two
         * attributes: a base value and a priority value (used for completing the heuristic
         * method of the knight's tour. The base value (myValue) indicates the knight's position
         * on turn n. A zero value indicates that the knight has not touched the square yet.
         */

        // PARAMETERS
        private int priority;   // heuristic priority value
        private int myValue;    // turn on which the knight touched the square

        // CONSTRUCTOR
        public Square() { } // END default constructor
        public Square(int p)
        {
            // priority is set on construction
            priority = p;
        } // END constructor Square(int)

        // METHODS
        public int getPriority()
        {
            return priority;
        } // END getPriority() -> int

        public void setPriority(int n)
        {
            priority = n;
        } // END setPriority(int)

        public int getValue()
        {
            return myValue;
        } // END getValue() -> int

        public void setValue(int n)
        {
            myValue = n;
        } // END setValue(int)

    } // END class Square
}
