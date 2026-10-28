namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana un número i mostra la suma de tots els números d'1 fins
             * a aquest número.
             */
            int numero = 0;

            Console.Write("Escriu un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Suma d'1 a {numero}: {SumaFins(numero)}");
        }
        /// <summary>
        /// Suma comencant per 0 fins al numero introduit
        /// </summary>
        /// <param name="limit">El numero utilitzat com a limit</param>
        /// <returns></returns>
        static int SumaFins(int limit)
        {
            int resultat = 0;

            for (int numero = 1; numero <= limit; numero ++)
            {
                resultat += numero;
            }

            return resultat;
        }

    }
}
