using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Lists_console_START
{
    internal class Program
    {
        /*
         * NAAM: 
         * KLAS:
        */

        static void Main(string[] args)
        {
            // consolekleuren instellen
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            // Declaratie
            List<string[]> cars = new List<string[]>();



            // Zoekopdrachten
            Console.WriteLine("\n--- Zoekopdrachten en filters ---\n");


            // 1. Zoek de eerste wagen met benzine als brandstof
            Console.WriteLine("Eerste wagen met benzine:");



            // 2. Vind alle wagens onder een bepaalde prijs (bijvoorbeeld onder 15000 euro)
            Console.WriteLine("\nWagens onder 15.000 EUR:");
   


            // 3. Zoek wagens van een specifiek merk (bijvoorbeeld "Fiat")
            Console.WriteLine("\nAlle wagens van het merk Fiat:");
  


            // 4. Zoek alle wagens met hybride aandrijving (zoek op "Elektrisch/Benzine")
            Console.WriteLine("\nAlle hybride wagens:");




            // 5. Zoek wagens met CO2-uitstoot hoger dan 120 g/km
            Console.WriteLine("\nWagens met CO2-uitstoot hoger dan 120 g/km:");
  





            // wachten op enter
            Console.WriteLine("\nDruk op enter om te eindigen.");
            Console.ReadLine();
        }


        // Bestand inlezen
        private static void BestandInlezen(List<string[]> cars)
        {
            // bestand inlezen, list vullen
            string volledigeLijn;

            // Citroen;Citroen C3;Benzine;11723;Citroen C3 1.2 PureTech;122
            using (StreamReader streamLees = new StreamReader("auto_export_file.txt"))
            {
                while (!streamLees.EndOfStream)
                {
                    volledigeLijn = streamLees.ReadLine();
                    // De split voegt een array toe aan de List.
                    cars.Add(volledigeLijn.Split(';'));
                }
            }
        }

        // Verkort de tekst indien nodig
        private static string ShortItem(string item, int lengte)
        {
            return item.Length > lengte ? item.Substring(0, lengte) + "..." : item;
        }
    }
}
