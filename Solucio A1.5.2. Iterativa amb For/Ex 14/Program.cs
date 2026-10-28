namespace Ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana una mida i dibuixa un quadrat d'asteriscs d'aquesta mida.
             */
            int mida;
            const char PINZELL = '*';

            Console.Write("Mida del quadrat: ");
            mida = Convert.ToInt32(Console.ReadLine());

            for (int midaActual = 1; midaActual <= mida; midaActual++)
            {
                if (midaActual == mida)
                {
                    Console.Write($"{GenerarLinia(PINZELL, mida)}");
                }
                else
                {
                    Console.Write($"{GenerarLinia(PINZELL, mida)}\n");
                }

            }
        }
        /// <summary>
        /// Returna un string especific depenent delcaracter i la longitud
        /// </summary>
        /// <param name="caracter">El caracter a pintar</param>
        /// <param name="longitud">La longitud de la linia</param>
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

    }
}
