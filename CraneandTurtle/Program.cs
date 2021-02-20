using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraneandTurtle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int totalAnimals = int.Parse(input[0]);
            int totalLegs = int.Parse(input[1]);

            int[] AnimalBox = new int[totalAnimals];
            for (int i = 0; i < totalAnimals; i++)
                AnimalBox[i] = 2;

            while (totalAnimals > 0)
            {
                if (AnimalBox.Sum() == totalLegs)
                    break;
                AnimalBox[totalAnimals - 1] = 4;
                totalAnimals--;
            }
            if(AnimalBox.Sum() == totalLegs)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
