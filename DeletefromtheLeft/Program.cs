using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletefromtheLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindMinMoves(Console.ReadLine(), Console.ReadLine()));
        }
        static int FindMinMoves(string String1, string String2)
        {
            int MovesReq = 0;
            for (int i = 1; i < String2.Length; i++)
            {
                MovesReq++;
                for (int j = 1; j < String1.Length; j++)
                {
                    MovesReq++;
                    if (String1.Substring(j, String1.Length - j) == String2.Substring(i, String2.Length - i))
                        return MovesReq;
                }
            }
            if ((MovesReq - 1) == (String1.Length + String2.Length))
                return (String1.Length + String2.Length);
            else
                return MovesReq;
        }
    }
}
