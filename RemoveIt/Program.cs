using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveIt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NsAndInputs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] Numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int ToRemove = NsAndInputs[1];

            foreach (int item in Numbers)
                if (item != ToRemove)
                    Console.Write(item + " ");
        }
    }
}
