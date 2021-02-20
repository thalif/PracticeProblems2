using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoGram
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalInputs = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int max = 0;
            string Gram = string.Empty;
            for (int i = 0; i < input.Length - 1; i++)
            {
                string gram = input[i]+input[i + 1].ToString();
                int temp = GetCoutForGram(input, gram);
                if (max < temp)
                {
                    max = temp;
                    Gram = gram;
                }
            }
            Console.WriteLine(Gram);
        }
        static int GetCoutForGram(string input,string gram)
        {
            int count = 0;
            for (int i = 0; i < input.Length -1 ; i++)
                if (input[i] == gram[0] && input[i + 1] == gram[1])
                    count++;
            return count;
        }
    }
}
