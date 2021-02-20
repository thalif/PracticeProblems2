using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takoyaki
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');

            int Nitems = int.Parse(inputs[0]);
            int Xpieces = int.Parse(inputs[1]);
            int Time = int.Parse(inputs[2]);

            int totalP = 0;
            int count = 0;
            while (totalP < Nitems)
            {
                count++;
                totalP += Xpieces;
            }
            Console.WriteLine(count * Time);
        }
    }
}
