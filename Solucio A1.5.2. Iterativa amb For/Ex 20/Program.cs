namespace Ex_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: genera 30 temperatures màximes diàries a l'atzar, entre 10 i
             * 35 graus (llavor 2026), i les mostra en una línia. Després mostra la temperatura
             * més alta, la més baixa i la mitjana, arrodonida a un decimal.
             */
            Random aleatori = new Random(2026);

            int maxima = 0, minima = 0, sumaTemp = 0;

            for (int temperatura = 0, voltes = 1; voltes <= 30; voltes++)
            {
                temperatura = aleatori.Next(10, 36);
                if (voltes == 1)
                {
                    maxima = temperatura;
                    minima = temperatura;
                }
                Console.Write($"{temperatura} ");

                if (temperatura > maxima)
                {
                    maxima = temperatura;
                }
                else if (temperatura < minima)
                {
                    minima = temperatura;
                }
                sumaTemp += temperatura;
            }
            Console.WriteLine($"\nMàxima: {maxima}");
            Console.WriteLine($"Mínima: {minima}");
            Console.WriteLine($"Mitjana: {sumaTemp / 30.0}");
        }
    }
}
