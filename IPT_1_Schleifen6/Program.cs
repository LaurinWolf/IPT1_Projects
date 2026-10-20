using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT_1_Schleifen6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int auswahl; do
            {

                Console.Write("Wähle 1 oder 2 oder 3: ");

                auswahl = Convert.ToInt32(Console.ReadLine());

            } while (auswahl != 1 && auswahl != 2 && auswahl != 3); Console.WriteLine("Auswahl gespeichert.");
        }
    }
}
