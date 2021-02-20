using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            List<int> Results = new List<int>();
            Results.Add(a + b * c);
            Results.Add(a * (b + c));
            Results.Add(a * b * c);
            Results.Add((a + b) * 3);
            Results.Sort();
            Console.WriteLine(Results[3]);
        }
    }
}