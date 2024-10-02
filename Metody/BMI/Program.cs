using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double výškaM, váhaKg, BMI;
            výškaM = ZadejDesetinneCislo(0, 3, "Zadej výšku (0 až 3 m): ");
            //Console.WriteLine(výškaM);
            váhaKg = ZadejDesetinneCislo(0, 400, "Zadej váhu (0 až 400 kg): ");
            //Vypočítání BMI
            BMI = VýpočetBMI(výškaM, váhaKg);
            //Výsledek
            Console.WriteLine(VysledekBMI(BMI));
        }
        //metoda načte desetinné číslo v daném rozsahu
        //vstup: double _od, _do, text hláška
        //výstup: desetinné číslo v daném rozsahu


        static double ZadejDesetinneCislo(double _od, double _do, string _hlaska)
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


        //metoda vypočítá BMI
        //vstup: výškaM, váhaKg (des. čísla)
        //výstup: des. číslo BMI podle vzorce BMI=váha/výška2
        static double VýpočetBMI(double _výškaM, double _váhaKg)
            {
            return _váhaKg / Math.Pow(_výškaM, 2);
            }


        //metoda vrátí výsledek BMI
        static string VysledekBMI(double _BMI)
        {
            StringBuilder výsledek = new StringBuilder();
            výsledek.Append("Tvůj výsledek BMI je: ");
            if (_BMI < 18.5) výsledek.Append("podváha!");

            else if (_BMI >= 18.5 & _BMI < 25) výsledek.Append("normální váha chlapče :) ");

            else if (_BMI >= 25.0 & _BMI < 30) výsledek.Append("nadváha!");

            else if (_BMI >= 30.0 & _BMI < 34.9) výsledek.Append("obezita 1. stupně!");

            else výsledek.Append("OBEZITA 2. STUPNĚ chlape !!!");
            return výsledek.ToString();
        }
    }
}