using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyDEMO
{
    internal class Program
    {

        //program vypočítá obsah kruhu
        static void Main(string[] args)
        { 
            double zadanýPoloměr = NačtiDesetinnéČíslo(0, 100, "Zadej poloměr kruhu");  
            double obsah = ObsahKruhu(zadanýPoloměr);
            Console.WriteLine(VypisVysledek(zadanýPoloměr, obsah));
        }

        //metoda načte od uživatele poloměr desetinné číslo
        //v rozmezí od-do (včetně krajních hodnot)
        //in: double od/do
        //out: double poloměr
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
            } while (!(poloměr>=_od & poloměr<=_do));
            return poloměr;
        }

        //APLIKAČNÍ LOGIKA
        //metoda vypočítá obsah kruhu
        //in: poloměr
        //out: (double) obsahKruhu
        static double ObsahKruhu(double _poloměr)
        { 
          return Math.PI*Math.Pow(_poloměr, 2);
        }

        //metoda vrátí řetězec s výsledkem výpočtu
        //in: _poloměr, _obsah
        //out: string
        static string VypisVysledek(double _poloměr, double _obsah)
        { 
           StringBuilder sb = new StringBuilder();
            sb.Append("Obsah kruhu s poloměrem ");
            sb.Append(_poloměr.ToString());
            sb.Append(" m je ");
            sb.Append(_obsah.ToString());
            sb.AppendLine(" m2");
            return sb.ToString();
        }

    }
}
