namespace Ex02
{
    /// <summary>
    /// Reparteix caramels
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            string?  resposta;
            int  CarmelsTotals;
            int  NensTotals;
            int CarmelsPerNen;
            int RestaCarmels;

            Console.WriteLine("Quants nens hi ha a calse? ");
            // resposta = Console.ReadLine();
            // NensTotals = Convert.ToInt32(resposta);

            NensTotals = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quants carmels hi ha en total? ");
            CarmelsTotals = Convert.ToInt32(Console.ReadLine());

            CarmelsPerNen = CarmelsTotals / NensTotals;
            RestaCarmels = CarmelsTotals % NensTotals;

            Console.WriteLine($"En una clase de {NensTotals} nens i {CarmelsTotals} caramels, a cada nen li pertoquen {CarmelsPerNen} i sobraran {RestaCarmels}");

            
        }
    }
}
