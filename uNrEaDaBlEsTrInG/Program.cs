using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uNrEaDaBlEsTrInG
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            string IsReadablity = "No";
            for(int i = 0; i < Input.Length; i+=2)
                try
                {
                    if (Input[i + 1] < 97 && Input[i] >= 97)
                        continue;
                    else
                        break;
                }
                catch
                {
                    IsReadablity = "Yes";
                }
            Console.WriteLine(IsReadablity);
        }
    }
}
