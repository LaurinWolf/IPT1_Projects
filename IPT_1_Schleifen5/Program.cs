using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_1_Schleifen5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tickets = 1;
            while (tickets <= 4)
            {
                Console.WriteLine("Ticket " + tickets);
                tickets++;
            }
        }
    }
}
