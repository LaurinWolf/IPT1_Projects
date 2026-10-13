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
            string artikelname;
            
       
            decimal einzelpreis;
           

            int menge;
           

            decimal mengenpreis;
            decimal gesamtpreis = 0;


            string weitere = "ja";





            while (weitere == "ja")
            {

                Console.WriteLine("Artikelname eingeben");
                artikelname = Console.ReadLine();
                Console.WriteLine("Preis eingeben");
                einzelpreis = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Menge eingeben");
                menge = Convert.ToInt32(Console.ReadLine());
                mengenpreis = menge * einzelpreis; 
                if (menge < 0)
                {
                    Console.WriteLine("Fehler: Die Menge darf nicht negativ sein.");
                }
                else
                {
                    mengenpreis = menge * einzelpreis;

                    if (menge >= 5)
                    {
                        mengenpreis = mengenpreis - mengenpreis * 20 / 100;   // 20 % abziehen
                    }
                    else if (menge >= 3)
                    {
                        mengenpreis = mengenpreis - mengenpreis * 10 / 100;   // 10 % abziehen
                    }
                    // Menge 1-2: kein Rabatt
                    Console.WriteLine(artikelname + " | " + einzelpreis + " | " + menge + " | " + mengenpreis + "\n" + artikelname + " | " + einzelpreis + " | " + menge + " | " + mengenpreis);

                    gesamtpreis += mengenpreis;
                    Console.WriteLine("Weitere Artikel? (ja/nein)");
                    weitere = Console.ReadLine();

                }
            }

            Console.WriteLine("Bezahlen: " + gesamtpreis + " chf");
            Console.ReadLine();

        }
    }
}
