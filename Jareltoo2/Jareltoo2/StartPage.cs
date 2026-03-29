using System;

namespace Jareltoo2
{
    public class StartPage
    {
        static void Main(string[] args)
        {
            bool tootan = true;

            while (tootan)
            {
                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1 - Taksosõidu kalkulaator");
                Console.WriteLine("2 - Kellaaja eraldaja");
                Console.WriteLine("3 - Täringu statistika");
                Console.WriteLine("4 - Ringi arvutused");
                Console.WriteLine("0 - Välju");
                Console.Write("Sinu valik: ");

                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Funktsioonid.TaksoKalkulaator();
                        break;

                    case "2":
                        Console.Write("Sisesta kellaaeg (HH:MM:SS): ");
                        string kellaaeg = Console.ReadLine();
                        Funktsioonid.HindaKellaaega(kellaaeg);
                        break;

                    case "3":
                        Funktsioonid.TaringuStatistika();
                        break;

                    case "4":
                        Console.Write("Sisesta ringi raadius: ");
                        double raadius = double.Parse(Console.ReadLine());

                        Tuple<double, double> tulemus = Funktsioonid.ArvutaRing(raadius);

                        Console.WriteLine($"Pindala: {Math.Round(tulemus.Item1, 2)} ruutuhikut");
                        Console.WriteLine($"Umbermoot: {Math.Round(tulemus.Item2, 2)} uhikut");
                        break;

                    case "0":
                        Console.WriteLine("Head aega!");
                        tootan = false;
                        break;

                    default:
                        Console.WriteLine("Vigane valik, proovi uuesti.");
                        break;
                }
            }
        }
    }
}
