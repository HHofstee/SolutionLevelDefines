using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionLevelDefines
{
    class Program
    {
        static void Main(string[] args)
        {
#if DOYOURTHING
            Console.WriteLine("Do your thing");
#else
            Console.WriteLine("Don't do your thing");
#endif
            Console.ReadLine();
        }
    }
}
