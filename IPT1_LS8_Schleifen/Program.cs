using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT1_LS8_Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menge1;
            do
            {
                Console.Write("Menge: ");
                menge1 = Convert.ToInt32(Console.ReadLine());

                if (menge1 <= 0)
                {
                    Console.WriteLine("Ungültige Menge.");
                }
            } while (menge1 <= 0);

            Console.WriteLine("Menge übernommen: " + menge1);

            Console.ReadLine();
        }
    }
}
