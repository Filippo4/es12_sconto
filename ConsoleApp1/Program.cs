using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double SCONTO_300 = 300 / 100 * 10;
            double sconto;
            Console.WriteLine("inserire l' importo");
            double importo = double.Parse(Console.ReadLine());
            if (importo <= 300)
            {
                sconto = importo / 100 * 10;
                double importo_scontato = importo - sconto;
                Console.WriteLine($"l'importo scontato è {importo_scontato},lo sconto è di {sconto}");
            }
            if (importo > 300)
            {
                double importo2 = importo - 300;
                double sconto2 = importo2 / 100 * 20;
                double scontoTot = SCONTO_300 + sconto2;
                double importo_scontato = importo - scontoTot;
                Console.WriteLine($"l'importo da pagare è {importo_scontato},lo sconto è di {scontoTot}");
            }
            Console.ReadLine();
        }
    }
}
