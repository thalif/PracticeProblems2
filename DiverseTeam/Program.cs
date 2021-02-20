using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiverseTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs1 = Console.ReadLine().Split(' ');
            string[] inputs2 = Console.ReadLine().Split(' ');

            int nStud = int.Parse(inputs1[0]);
            int needed = int.Parse(inputs1[1]);

            Dictionary<int, int> results = new Dictionary<int, int>();
            for (int i = 0; i < inputs2.Length; i++)
                if (!results.ContainsValue(int.Parse(inputs2[i])))
                    results.Add(i+1, int.Parse(inputs2[i]));

            if(results.Count() >= needed)
            {
                string stud = string.Empty;
                Console.WriteLine("YES");
                for (int i = 0; i < needed; i++)
                    stud += results.Keys.ToList()[i] + " ";
                
                Console.Write(stud.Trim());
            }
            else
                Console.WriteLine("NO");
        }
    }
}
