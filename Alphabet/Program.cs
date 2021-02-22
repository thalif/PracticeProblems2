using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char Alpha = char.Parse(Console.ReadLine());
            if (Alpha <= 90)
                Console.WriteLine("A");
            else
                Console.WriteLine("a");
        }
    }
}
