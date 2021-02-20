using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilName
{
    class Program
    {
        static void Main(string[] args)
        {
            int Ninputs = int.Parse(Console.ReadLine());
            string fileName = Console.ReadLine();

            int charsToRemove = 0;
            for (int i = 0; i < fileName.Length; i++)
            {
                try
                {
                    if (fileName[i] == 'x' && fileName[i + 1] == 'x' && fileName[i + 2] == 'x')
                        charsToRemove++;
                }
                catch (IndexOutOfRangeException ex)
                {
                    break;
                }       
            }
            Console.WriteLine(charsToRemove);
        }
    }
}
