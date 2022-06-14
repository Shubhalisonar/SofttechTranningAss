using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofttechTranningAss
{
    internal class OddNo
    {
        public static void main1()
        {
            Console.WriteLine("Odd numbers from 1 to 99. Prints one number per line.");
            for (int n = 1; n < (99 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }

        }
    }
}
