using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// Creating ConsoleApp to the Monkeys Crossing a Rope concept.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            // Setting Variables for the 2 input boxes
            var iA = 5;
            var iB = 17;

            // Additional counters to ensure both side get to go
            var aCount = 0;
            var bCount = 0;

            // Setting While Repeater
            // Added condition for both A & B
            while (iA > 0 || iB > 0)
            {
                // Reset Queue for each loop
                var iQueue = 0;

                // Ensures both side get to go
                if ((iA >= iB && aCount == bCount) || bCount > aCount)
                {
                    // Queue value should be max of 3 
                    // But uses the whole count when the other side is 0
                    if (iB == 0) { iQueue = iA; }
                    else { if (iA > 3) { iQueue = 3; } else { iQueue = iA; } }

                    // Setting Monkeys Crossing thru a for loop
                    for (var i = 1; i < iQueue + 4; i++) // Added additional values to the queue to ensure the monkeys can get out
                    {
                        // Subtraction of total pending monkeys and ensure that does not take more than the queue
                        if (i <= iQueue) { iA--; }

                        // Stablish Monkey position using MOD 
                        var iPos = i % 4;

                        // Each Position represents the various stages of the Rope Crossing scenarios (25%, 50%, 75% & 100%)
                        // Add additional filtering to ensure each monkey in the queue gets thru
                        var iPos1 = (iPos == 1 && i < iQueue + 1) || (i >= 1 && i < iQueue + 1) ? true : false;
                        var iPos2 = (iPos == 2 && i < iQueue + 2) || (i >= 2 && i < iQueue + 2) ? true : false;
                        var iPos3 = (iPos == 3 && i < iQueue + 3) || (i >= 3 && i < iQueue + 3) ? true : false;
                        var iPos4 = (iPos == 0 && i < iQueue + 4) || (i >= 4 && i < iQueue + 4) ? true : false;

                        // Change True/False to ASCII character to make it easier to read
                        // Add counter to each row
                        // Changed counter to reflect where it originates from
                        Console.WriteLine("{0}{1}{2}{3}{4}", iA, iPos1 ? "*" : "_", iPos2 ? "*" : "_", iPos3 ? "*" : "_", iPos4 ? "*" : "_");
                    }
                    // Provides A with a reflected round
                    aCount++;
                }
                else
                {
                    // Create crossing path from other direction

                    // Same as above but inverted
                    if (iA == 0) { iQueue = iB; }
                    else { if (iB > 3) { iQueue = 3; } else { iQueue = iB; } }

                    for (var i = 1; i < iQueue + 4; i++)
                    {
                        if (i <= iQueue) { iB--; }

                        var iPos = i % 4;
                        var iPos1 = (iPos == 1 && i < iQueue + 1) || (i >= 1 && i < iQueue + 1) ? true : false;
                        var iPos2 = (iPos == 2 && i < iQueue + 2) || (i >= 2 && i < iQueue + 2) ? true : false;
                        var iPos3 = (iPos == 3 && i < iQueue + 3) || (i >= 3 && i < iQueue + 3) ? true : false;
                        var iPos4 = (iPos == 0 && i < iQueue + 4) || (i >= 4 && i < iQueue + 4) ? true : false;

                        // Need to invert sequence to reflect bi-directional traffic
                        Console.WriteLine("{0}{1}{2}{3}{4}", iPos4 ? "*" : "_", iPos3 ? "*" : "_", iPos2 ? "*" : "_", iPos1 ? "*" : "_", iB);
                    }
                    // Provides A with a reflected round
                    bCount++;
                }
            }
        }
    }
}
