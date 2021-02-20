using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoungPhysicist
{
    class Program
    {
        static void Main(string[] args)
        {
            int NcoOrdinates = int.Parse(Console.ReadLine());

            string[] AllCoOrdinates = new string[NcoOrdinates];
            for (int i = 0; i < NcoOrdinates; i++)
                AllCoOrdinates[i] = Console.ReadLine();

            int VectorsCount = 0;
            for (int i = 0; i < 3; i++)
                if (check(AllCoOrdinates, i))
                    VectorsCount++;
                else
                    break;

            if (VectorsCount == 3)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        static bool check(string[] arr, int position)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                string[] singleCoOrdinate = arr[i].Split(' ');
                sum += int.Parse(singleCoOrdinate[position]);
            }
            return sum == 0;
        }
    }
}
