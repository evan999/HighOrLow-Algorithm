using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPlusLow
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessRound hand = new ProcessRound();
            hand.Round(10, 0);
        }
    }
}
