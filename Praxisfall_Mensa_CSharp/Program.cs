using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praxisfall_Mensa_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string artikelname1;
            string artikelname2;
       
            decimal einzelpreis1;
            decimal einzelpreis2;

            int menge1;
            int menge2;

            decimal mengenpreis1;
            decimal mengenpreis2;

            decimal gesamtpreis;

            
            
            


            Console.WriteLine("Artikelname eingeben");
            artikelname1 = Console.ReadLine();
            Console.WriteLine("Preis eingeben");
            einzelpreis1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Menge eingeben");
            menge1 = Convert.ToInt32(Console.ReadLine());
            mengenpreis1 = menge1 * einzelpreis1;
            Console.WriteLine("Mengenpreis " + mengenpreis1);

            //Console.Writeline("Mengenpreis: " + mengenpreis1;

            Console.WriteLine("Artikelname eingeben");
            artikelname2 = Console.ReadLine();
            Console.WriteLine("Preis eingeben");
            einzelpreis2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Menge eingeben");
            menge2 = Convert.ToInt32(Console.ReadLine());
            mengenpreis2 = menge2 * einzelpreis2;
            Console.WriteLine("Mengenpreis " + mengenpreis2);

            //Console.Writeline("Mengenpreis: " + mengenpreis1;

            Console.WriteLine(artikelname1 + " | " + einzelpreis1 + " | " + menge1 + " | " + mengenpreis1 + "\n" + artikelname2 + " | " + einzelpreis2 + " | " + menge2 + " | " + mengenpreis2);
              

            Console.ReadLine();




        }
    }
}
