using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_1_Schleifen4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Countdown = 5;
            int Countdown2 = 1;

            while (Countdown > 0)
            {
                Console.WriteLine(Countdown);
                Countdown--;
            }
            Console.WriteLine("Start!");
            Console.WriteLine("\n");

            while (Countdown2 < 6)
            {
                Console.WriteLine(Countdown2);
                Countdown2 ++;
            }
            Console.WriteLine("Start!");
        }
    }
    }

