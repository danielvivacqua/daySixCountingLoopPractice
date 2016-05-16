using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daySixCountingLoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 2 numbers. First, type your lower number.");
            int numFrom = int.Parse(Console.ReadLine());
            Console.WriteLine("Now enter the bigger number.");
            int numTo = int.Parse(Console.ReadLine());


            if (numFrom <= numTo)
            {
                while (numFrom <= numTo)
                {
                    Console.WriteLine(numFrom);
                    numFrom++;
                }
            }
            else
            {
                Console.WriteLine("You didn't follow directions! Remember, type the lower number first, and the bigger number second!");
            }
        }
    }
}
