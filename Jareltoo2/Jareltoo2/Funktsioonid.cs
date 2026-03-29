using System;
using System.Collections.Generic;
using System.Text;

namespace Jareltoo2
{
    internal class Funktsioonid
    {
        public static void TaksoKalkulaator()
        {
            Console.Write("Sisesta sisseistumistasu (€): ");
            double sisseistumistasu = double.Parse(Console.ReadLine());

            Console.Write("Sisesta kilomeetri hind (€/km): ");
            double kmHind = double.Parse(Console.ReadLine());

            Console.Write("Sisesta läbitud kilomeetrid (km): ");
            double kilomeetrid = double.Parse(Console.ReadLine());

            double kogumaksumus = sisseistumistasu + (kmHind * kilomeetrid);

            Console.WriteLine($"Taksosõidu kogumaksumus: {kogumaksumus:F2} €");
        }

        public static void HindaKellaaega(string kellaaeg)
        {
            if (kellaaeg.Length != 8)
            {
                Console.WriteLine("Vigane kellaaja formaat!");
                return;
            }

            string tunnid = kellaaeg.Substring(0, 2);
            string minutid = kellaaeg.Substring(3, 2);
            string sekundid = kellaaeg.Substring(6, 2);

            Console.WriteLine($"Kell on täpselt {tunnid} tundi, {minutid} minutit ja {sekundid} sekundit.");
        }

        public static void TaringuStatistika()
        {
            Random juhuslik = new Random();
            List<int> tulemused = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                tulemused.Add(juhuslik.Next(1, 7));
            }

            Console.WriteLine("Viske tulemused: " + string.Join(", ", tulemused));

            int kuuedArv = 0;
            foreach (int tulemus in tulemused)
            {
                if (tulemus == 6)
                {
                    kuuedArv++;
                }
            }

            Console.WriteLine($"Numbrit 6 visati {kuuedArv} korda.");
        }

        public static Tuple<double, double> ArvutaRing(double raadius)
        {
            double pindala = Math.PI * raadius * raadius;
            double umbermoot = 2 * Math.PI * raadius;

            return new Tuple<double, double>(pindala, umbermoot);
        }
    }
}
