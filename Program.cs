using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //User Story "Addieren": Als Benutzer möchte ich 2 Zahlen eingeben, um die Summe zu berechnen
            Console.Write("Geben Sie die erste Zahl ein: ");
            string ersterString = Console.ReadLine();
            Console.Write("Geben Sie die zweite Zahl ein: ");
            string zweiterString = Console.ReadLine();

            // Umwandlung in Gleitkommazahlen
            float ersteZahl = Convert.ToSingle(ersterString);
            float zweiteZahl = Convert.ToSingle(zweiterString);

            // Berechnung
            float Summe = ersteZahl + zweiteZahl;

            //Ausgabe
            Console.WriteLine("Die Summe lautet: {0}", Summe);
            Console.ReadKey();

            //float pi = 3.14F;
            //Console.WriteLine("pi  = {0}", pi);
            //float pi2 = 0.0314e2F;
            //Console.WriteLine("pi2  = {0}", pi2);

            //float max = float.MaxValue;
            //Console.WriteLine("max   = {0:F}", max);

            //float a = 123456789.01F;
            //float b = 123456789.02F;
            //Console.WriteLine("a   = {0:F}", a);
            //Console.WriteLine("b   = {0:F}", b);


            Console.ReadKey();
        }
    }
}
