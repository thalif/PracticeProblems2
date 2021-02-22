using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirConditioner
{
    class Program
    {
        static void Main(string[] args)
        {
            int RoomTemperature = int.Parse(Console.ReadLine());
            if(RoomTemperature >= 30)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
