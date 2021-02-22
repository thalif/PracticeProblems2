using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            string BillAmount = Console.ReadLine();
            int WeReceive = 0;
            while(!BillAmount.Contains("000"))
            {
                WeReceive++;
                BillAmount = (int.Parse(BillAmount) + 1).ToString();
            }
            Console.WriteLine(WeReceive);
        }
    }
}
