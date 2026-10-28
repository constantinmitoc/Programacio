namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra els 20 primers números parells, amb el mateix format
             * de l'exercici 1.
             */
            int numero = 0;

            for (numero = 2; numero < 40; numero += 2)
            {
                Console.Write($"{numero}, ");
            }
            Console.Write($"{numero}");
        }
    }
}
