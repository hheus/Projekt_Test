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
            // User Story "Addieren": Als Benutzer möchte ich 2 Zahlen eingeben, um die Summe zu berechnen
            Console.Write("Geben Sie die erste Zahl ein: ");
            string ersterString = Console.ReadLine();
            Console.Write("Geben Sie die zweite Zahl ein: ");
            string zweiterString = Console.ReadLine();

            // Umwandlung
            int ersteZahl = Convert.ToInt32(ersterString);
            int zweiteZahl = Convert.ToInt32(zweiterString);

            // Berechnung
            int Summe = ersteZahl + zweiteZahl;

            //Ausgabe
            Console.WriteLine("Die Summe lautet: {0}", Summe);
            Console.ReadKey();
        }
    }
}
