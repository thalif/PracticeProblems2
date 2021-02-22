using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeLoveGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());;
            int[] AandB = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int A = AandB[0];
            int B = AandB[1];
            
            string Result = "NG";
            for (int i = A; i <= B; i++)
                if (i % K == 0)
                {
                    Result = "OK";
                    break;
                }
            Console.WriteLine(Result);
        }
    }
}
