namespace Ex_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: llança dos daus 1000 vegades (llavor 2026) i compta quantes 
             * vegades la suma dels dos daus és 7. Al final, mostra el recompte i el percentatge,
             * arrodonit a un decimal.
             */
            Random aleatori = new Random(2026);
            int vegadesQueSuma7 = 0;

            Console.WriteLine("Llançaments: 1000");
            for (int dau = 0, llencament = 0, numTemp = 0; llencament <= 1000;
                llencament++, numTemp = 0)
            {
                dau = aleatori.Next(1, 7);
                numTemp += dau;
                dau = aleatori.Next(1, 7);
                numTemp += dau;
                
                if (numTemp == 7)
                {
                    vegadesQueSuma7++;
                }
            }
            Console.WriteLine($"Vegades que sumen 7: {vegadesQueSuma7}");
            Console.WriteLine($"Percentatge: {(double)vegadesQueSuma7 / 1000.0 * 100}%");
        }
    }
}
