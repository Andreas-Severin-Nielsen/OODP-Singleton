using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton ref1 = Singleton.Instance;
            Singleton ref2 = Singleton.Instance;

            Console.WriteLine("ref1: " + ref1.ToString());
            Console.WriteLine("swapping the strings on ref2.");
            ref2.Swap();
            Console.WriteLine("ref1: " + ref1.ToString());
            Console.WriteLine("ref1 and ref2 are the same: " + (ref1 == ref2).ToString());
            Console.ReadKey();
        }
    }
}
