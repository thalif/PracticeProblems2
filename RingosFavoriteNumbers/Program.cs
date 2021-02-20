using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RingosFavoriteNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            Console.WriteLine(Math.Pow(100, double.Parse(inputs[0])) * double.Parse(inputs[1]));
            Console.ReadKey();
        }
    }
}
