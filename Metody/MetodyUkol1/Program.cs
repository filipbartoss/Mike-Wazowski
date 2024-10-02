using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyUkol1
{
    internal class Program
    {
        /*
         * Napište program, který pro základní geometrické tvary
         * vypíše jejich obvod a obsah (případně povrch a objem).
         * V úvodu program vypíše nabídku možných geometrických tvarů
         * ( kruh, koule), 
         * Potom:
         * přičemž každý tvar bude mít přiřazeno číslo nebo písmeno.
         * Jakmile uživatel zvolí konkrétní geometrický tvar,
         * bude dotázán na potřebné vstupní parametry (délky stran, poloměr, výška...).
         * Nakonec program vypíše maximum výstupních informací a skončí.
         */
        static void Main(string[] args)
        {
            int číslo;
            Console.WriteLine("Zadej číslo 1-2 (1 = kruh, 2 = koule)");
            while (!int.TryParse(Console.ReadLine(), out číslo));

            if (číslo == 1) 
            {
                

                double zadanýPoloměr = NačtiDesetinnéČíslo(0, 100, "Zadej poloměr kruhu");
                double obsah = ObsahKruhu(zadanýPoloměr);
                Console.WriteLine(VypisVysledek(zadanýPoloměr, obsah));



            }
        }

        static double ObsahKruhu(double _poloměr)
        {
            return Math.PI * Math.Pow(_poloměr, 2);
        }

        static double NačtiDesetinnéČíslo(double _od, double _do, string _hláška)
                {
                    double poloměr;
                    StringBuilder sb = new StringBuilder();
                    sb.Append(_hláška);
                    sb.Append(" od: ");
                    sb.Append(_od.ToString());
                    sb.Append(" do: ");
                    sb.Append(_do.ToString());

                    do
                    {
                        Console.WriteLine(sb.ToString());
                        while (!double.TryParse(Console.ReadLine(), out poloměr)) ;
                    } while (!(poloměr >= _od & poloměr <= _do));
                    return poloměr;
                }
                
            }



    }