using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainySeason
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            if (S.Contains("SSS"))
                Console.WriteLine(0);
            else if (S.Contains("RRR"))
                Console.WriteLine("3");
            else if(S.Contains("RR"))
                Console.WriteLine(2);
            else if(S.Contains("R"))
                Console.WriteLine(1);
        }
    }
}
