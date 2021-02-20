using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoosingTeams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input1 = Console.ReadLine().Split(' ');
            string[] studStatus = Console.ReadLine().Split(' ');

            int Nstudents = int.Parse(input1[0]);
            int Contests = int.Parse(input1[1]);

            int AcceptableTeamMembers = 0;
            for (int i = 0; i < Nstudents; i++)
            {
                if (int.Parse(studStatus[i]) + Contests <= 5)
                    AcceptableTeamMembers++;
            }
            Console.WriteLine(AcceptableTeamMembers / 3);
        }
    }
}
