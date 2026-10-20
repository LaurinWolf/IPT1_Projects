using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPt_1_Schleifen_Mini_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Bücher;
            string weitere = "ja";




            do
            {
               

                do

                {
                    Console.WriteLine("Welches Buch wählen Sie? Wählen sie Buch 1-5");
                    Bücher = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Buch " + Bücher + " registriert.");
                    Bücher--;
                    Console.WriteLine("noch " + Bücher + "Bücher " + "\n");

                    Console.WriteLine("Möchten Sie ein weiteres Buch registrieren? (ja/nein)");
                    weitere = Console.ReadLine();
                } while (weitere == "ja");





            } while
            (Bücher != 1 && Bücher != 2 && Bücher != 3 && Bücher != 4 && Bücher != 5);









           

           
        }








    }
}

