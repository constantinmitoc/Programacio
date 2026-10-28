namespace Ex_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana una alçada i dibuixa una piràmide de números centrada.
             */
            int alcada = 0;
            const char BUIT = ' ';

            Console.Write("Alçada de la piràmide: ");
            alcada = Convert.ToInt32(Console.ReadLine());

            for (int limit = 1, limitBuit = alcada - 1; limit <= alcada; limit++, limitBuit--)
            {
                if (limit == alcada)
                {
                    Console.Write($"{GenerarLinia(BUIT, limitBuit)}{GenerarNumeros(limit)}");
                }
                else
                {
                    Console.Write($"{GenerarLinia(BUIT, limitBuit)}{GenerarNumeros(limit)}\n");
                }
            }

            /* 
                        1
                       1 2
                      1 2 3
                     1 2 3 4
                    1 2 3 4 5
             */
        }
        /// <summary>
        /// Retorna la quantitat de caracters necesaris
        /// </summary>
        /// <param name="caracter">El caracter que es repeteix</param>
        /// <param name="longitud">La quantitat de vegades que es repeteix</param>
        /// <returns></returns>
        static string GenerarLinia(char caracter, int longitud)
        {
            string resultat = "";

            for (int longitudFinsALimit = 0; longitudFinsALimit < longitud; longitudFinsALimit++)
            {

                resultat += ($"{caracter}");
            }

            return resultat;
        }
        /// <summary>
        /// Escriu els numeros necesaris per una fila en especific de la piramide
        /// </summary>
        /// <param name="longitud">La longitud de la fila</param>
        static string GenerarNumeros(int longitud)
        {
            string resultat = "";

            for (int limit = 1; limit <= longitud; limit++)
            {
                if (limit == longitud)
                {
                    resultat += $"{limit}";
                }
                else
                {
                    resultat += $"{limit} ";
                }
            }

            return resultat;
        }
    }
}
