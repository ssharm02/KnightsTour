using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Knights_Tour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRunTour_Click(object sender, EventArgs e)
        {
            /* Launches Knight's Tour program. User input dictates the number of attempts at
             * knight's tour, as well as method of the simulation. It then writes results of
             * each attempt to an output file located in the program's debug folder, and
             * displays statistics on execution of the program.
             */

            int attempts = (int)nuAttempts.Value;   // number of attempts at knight's tour
            bool method = rbMethodSmart.Checked;    // true if heuristic method selected
            Board board;
            string filename;    // name of output file
            if (method)
            {
                // holds results of heuristic method simulation
                filename = "ColinSarthakHeuristicsMethod.txt";
            }
            else
            {
                // holds results of dumb method simulation
                filename = "ColinSarthakNonIntelligentMethod.txt";
            }
            int[] rounds = new int[attempts];   // holds total moves for each attempt
            double average = 0; // average number of moves across all attempts
            double stdDev = 0;  // standard deviation of moves across all attempts
            // create writer to write to output file
            using (StreamWriter writer = new StreamWriter(filename))
            {
                for (int i = 0; i < attempts; i++)  // attempt knight's tour
                {
                    board = new Board(method);
                    board.knightsTour(method);
                    rounds[i] = board.getNumMoves();
                    average += rounds[i];
                    rtOutput.Text = board.toString();
                    writer.WriteLine("Trial " + (i + 1) + ":    The Knight was able to successfully touch " + (rounds[i] + 1) + " squares.\n");
                    Thread.Sleep(50);
                } // END knight's tour loop

            }
            // find and display average moves
            average = average / attempts;
            tbAverage.Text = average.ToString("00.00");
            if (attempts > 1)   // find and display standard deviation
            {
                foreach (int round in rounds)
                {
                    stdDev += (Math.Pow(round - average, 2));
                }
                stdDev = stdDev / (attempts - 1);
                tbStdDev.Text = stdDev.ToString("0.####");
            }
            else    // standard deviation not applicable
            {
                tbStdDev.Text = "";
            }
        } // END btRunTour_Click(object, EventArgs)

    } // END class Form1
}
