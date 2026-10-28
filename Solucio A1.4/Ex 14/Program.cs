namespace Ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: el mateix que l'exercici 13, però amb números de 4 xifres.
             */
            int numero = 0;

            Console.Write("Escriu un número de 4 xifres: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 1000 || numero > 9999)
            {
                Console.Write("El número ha de tenir 4 xifres.");
            }
            else if (EsCapICua(numero))
            {
                Console.Write($"{numero} és cap-i-cua.");
            }
            else
            {
                Console.Write($"{numero} no és cap-i-cua.");
            }

        }
        /// <summary>
        /// Retorna "true" si es cap-i-cua.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        static bool EsCapICua(int numero)
        {
            return numero / 1000 == numero % 10 &&
                ((numero / 100) % 10) == ((numero / 10) % 10);
        }
    }
}
