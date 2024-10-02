using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektALG___Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //uživatel zadá rychlost stahování v MB/s a velikost souboru v GB
            //převede velikost souboru z GB na MB
            //výpočet: velikost souboru / rychlost stahování souboru
            //aplikace vypíše dobu trvání stahování v minutách
            double zadanáRychlost, zadanáVelikostGB, velikostMB, doba;

            zadanáRychlost = ZadejDesetinnéČíslo(0, 100, "Zadej tvoji rychlost stahování Mb/s: ");
            zadanáRychlost = PrevodMbNaMBs(zadanáRychlost);
            zadanáVelikostGB = ZadejDesetinnéČíslo(0, 300, "Zadej velikost souboru v GB: ");
            velikostMB = zadanáVelikostGB * 1024;
            doba = dobaStahování(zadanáRychlost, velikostMB);
            Console.WriteLine(VypisVysledek(doba));
        }
        //metoda převede Mb/s na MB/s

        static double PrevodMbNaMBs(double _velikostMb)
        {
            double velikostMB;

            velikostMB = _velikostMb / 8;

            return velikostMB;
        }
        //metoda načte desetinné číslo

        static double ZadejDesetinnéČíslo(double _od, double _do, string _hlaska)
        {
            double zadaneCislo;

                do
                {
                Console.WriteLine(_hlaska);
                while (!double.TryParse(Console.ReadLine(), out zadaneCislo)) ;
            }
            while (!(zadaneCislo >= _od & zadaneCislo <= _do));
            return zadaneCislo;
        }
        //metoda vypočítá dobu stahování nejdříve v sekundách, následně ji převede na minuty

        static double dobaStahování(double _zadanáRychlost, double _velikostMB)
        {
            double dobaTrvaniSekundy, dobaTrvaniMinuty;

            dobaTrvaniSekundy = _velikostMB / _zadanáRychlost;
            dobaTrvaniMinuty = Math.Round(dobaTrvaniSekundy / 60);
            return dobaTrvaniMinuty;
        }
        //metoda vrátí výsledek

        static string VypisVysledek(double _doba)
        {
            StringBuilder výsledek = new StringBuilder();
            výsledek.Append("Budeš stahovat: ");
            výsledek.Append(_doba.ToString());
            výsledek.Append(" minut");
            return výsledek.ToString();

        }
    }
}
