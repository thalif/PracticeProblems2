using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedRemainders
{
    class Program
    {
        static void Main(string[] args)
        {

            int NInputs = int.Parse(Console.ReadLine());

            for (int j = 0; j < NInputs; j++)
            {
                int GivenArrayLength = int.Parse(Console.ReadLine());
                int[] GivenArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                int[] RemindersCounts = ReminderCountsFor(GivenArray);
                int MovesToMake = 0;
                for (int i = 0; i < RemindersCounts.Length; i++)
                    if (RemindersCounts[i] > (GivenArrayLength / 3))
                        MovesToMake += RemindersCounts[i] - (GivenArrayLength / 3);

                Console.WriteLine(MovesToMake > 1 ? (MovesToMake + 1) : MovesToMake);
            }
        }
        static int[] ReminderCountsFor(int[] givenArr)
        {
            int[] RemindersBox = new int[3];
            for (int i = 0; i < givenArr.Length; i++)
            {
                int theReminder = givenArr[i] % 3;
                if (theReminder == 0)
                    RemindersBox[0]++;
                else if (theReminder == 1)
                    RemindersBox[1]++;
                else if (theReminder >= 2)
                    RemindersBox[2]++;
            }
            return RemindersBox;
        }
    }
}
