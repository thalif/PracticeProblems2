using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());
            string[] inputs = Console.ReadLine().Split(' ');

            int toRemove = 0;
            for (int i = 0; i < Ninputs; i++)
                for (int j = i + 1; j < Ninputs; j++)
                    if (inputs[i] == inputs[j])
                    {
                        inputs[i] = "x";
                        toRemove++;
                        break;
                    }

            string Dups = string.Empty;
            foreach (string s in inputs)
                if(s != "x")
                    Dups +=  s+ " ";

            Console.WriteLine(inputs.Length - toRemove);
            Console.WriteLine(Dups.Trim());
        }
    }
}
