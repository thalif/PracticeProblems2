using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Therefore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] HON = new int[] { 2, 4, 5, 7, 9 };
            int[] PON = new int[] { 0, 1, 6, 8 };

            string N = Console.ReadLine();
            int LastDigit = int.Parse(N[N.Length - 1].ToString());
            if(HON.Contains(LastDigit))
                Console.WriteLine("hon");
            else if(PON.Contains(LastDigit))
                Console.WriteLine("pon");
            else
                Console.WriteLine("bon");
        }
    }
}
