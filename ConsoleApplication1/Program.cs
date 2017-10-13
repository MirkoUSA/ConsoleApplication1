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
            var iA = 2;
            var iB = 0;

            var iQueue = 0;

            // Setting While Repeater
            while (iA > 0)
            {

                if (iA > iB)
                {
                    // Queue value should be max of 3
                    if (iA > 3) { iQueue = 3; } else { iQueue = iA; }

                    // Setting Monkeys Crossing thru a for loop
                    for (var i = 0; i < iQueue; i++)
                    {
                        // Stablish Monkey Position
                        var iPos = i % 4;

                        // Each Position represents the various stages of the Rope Crossing scenarios (25%, 50%, 75% & 100%)
                        var iPos1 = iPos == 1 ? true : false;
                        var iPos2 = iPos == 2 ? true : false;
                        var iPos3 = iPos == 3 ? true : false;
                        var iPos4 = iPos == 4 ? true : false;


                        Console.WriteLine("{0}{1}{2}{3}", iPos1, iPos2, iPos3, iPos4 );

                    }

                }


                Console.WriteLine("{0} - {1}", iA, iB);

                iA--;
            }

        }
    }
}
