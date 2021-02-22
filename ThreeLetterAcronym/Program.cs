using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLetterAcronym
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ThreeLetters = Console.ReadLine().Split(' ');
            Console.Write(ThreeLetters[0][0].ToString().ToUpper());
            Console.Write(ThreeLetters[1][0].ToString().ToUpper());
            Console.Write(ThreeLetters[2][0].ToString().ToUpper());
        }
    }
}
