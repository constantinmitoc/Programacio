namespace Ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: llança un dau (llavor 2026) fins que arriba a la casella 63
             * o la passa, i mostra quantes tirades han calgut, quants sisos han sortit i a quina
             * casella s'ha acabat.
             */
            Random random = new Random(2026);

            int casella = 0, tirada = 0, tirades = 0, sisos = 0;

            while (casella < 63)
            {
                tirades++;
                tirada = random.Next(1, 7);
                casella += tirada;

                if (tirada == 6)
                {
                    sisos++;
                }
            }
            Console.WriteLine($"Tirades necessàries: {tirades}");
            Console.WriteLine($"Sisos: {sisos}");
            Console.WriteLine($"Casella final: {casella}");
        }
    }
}
