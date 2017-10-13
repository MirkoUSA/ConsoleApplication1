using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyBusinessClassLibrary
{
    public class clsMonkeyBusiness
    {
        /// <summary>
        /// This will be the same code used in the Console Application with just a few differences
        /// </summary>
        /// <param name="iValueA"></param>
        /// <param name="iValueB"></param>
        /// <returns></returns>

        public String[] XingMonkeys(int iValueA, int iValueB)
        {
            var iA = 5;
            var iB = 17;

            var aCount = 0;
            var bCount = 0;

            while (iA > 0 || iB > 0)
            {
                var iQueue = 0;

                if ((iA >= iB && aCount == bCount) || bCount > aCount)
                {
                    if (iB == 0) { iQueue = iA; }
                    else { if (iA > 3) { iQueue = 3; } else { iQueue = iA; } }

                    for (var i = 1; i < iQueue + 4; i++)
                    {
                        if (i <= iQueue) { iA--; }

                        var iPos = i % 4;
                        var iPos1 = (iPos == 1 && i < iQueue + 1) || (i >= 1 && i < iQueue + 1) ? true : false;
                        var iPos2 = (iPos == 2 && i < iQueue + 2) || (i >= 2 && i < iQueue + 2) ? true : false;
                        var iPos3 = (iPos == 3 && i < iQueue + 3) || (i >= 3 && i < iQueue + 3) ? true : false;
                        var iPos4 = (iPos == 0 && i < iQueue + 4) || (i >= 4 && i < iQueue + 4) ? true : false;

                        Console.WriteLine("{0}{1}{2}{3}{4}", iA, iPos1 ? "*" : "_", iPos2 ? "*" : "_", iPos3 ? "*" : "_", iPos4 ? "*" : "_");
                    }
                    aCount++;
                }
                else
                {
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

                        Console.WriteLine("{0}{1}{2}{3}{4}", iPos4 ? "*" : "_", iPos3 ? "*" : "_", iPos2 ? "*" : "_", iPos1 ? "*" : "_", iB);
                    }
                    bCount++;
                }
            }


            return null;
        }
    }
}
