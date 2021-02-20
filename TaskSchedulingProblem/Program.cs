using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSchedulingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int task1 = int.Parse(inputs[0]);
            int task2 = int.Parse(inputs[1]);
            int task3 = int.Parse(inputs[2]);
            Console.WriteLine(Math.Max(task1, Math.Max(task2, task3)) - Math.Min(task1, Math.Min(task2, task3)));
        }
    }
}
