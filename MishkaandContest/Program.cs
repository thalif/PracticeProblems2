using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MishkaandContest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs1 = Console.ReadLine().Split(' ');
            string[] inputs2 = Console.ReadLine().Split(' ');

            int totalProbs = int.Parse(inputs1[0]);
            int skill = int.Parse(inputs1[1]);

            int MishkaCanSolve= 0;
            for (int i = 0; i < totalProbs; i++)
                if (skill >= int.Parse(inputs2[i]))
                    MishkaCanSolve++;
                else
                    break;

            if (MishkaCanSolve != totalProbs)
                for (int i = totalProbs; i > 0; i--)
                    if (skill >= int.Parse(inputs2[i - 1]))
                        MishkaCanSolve++;
                    else
                        break;

            Console.WriteLine(MishkaCanSolve);
        }
    }
}
