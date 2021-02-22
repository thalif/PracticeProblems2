using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();

            for (int i = 0; i < T.Length; i++)
            {
                try
                {
                    if (T[i] != S[i])
                    {
                        Console.WriteLine("No");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Yes");
                    break;
                }   
            }
        }
    }
}
