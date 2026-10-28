namespace Ex_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana una alçada i dibuixa un triangle d'asteriscs. Fes servir
             * la funció GenerarLinia de l'exercici 14.
             */
            int mida;
            const char PINZELL = '*';

            Console.Write("Alçada del triangle: ");
            mida = Convert.ToInt32(Console.ReadLine());

            for (int midaActual = 1, midaLinia = 1; midaActual <= mida; midaActual++, midaLinia++)
            {
                if (midaActual == mida)
                {
                    Console.Write($"{GenerarLinia(PINZELL, midaLinia)}");
                }
                else
                {
                    Console.Write($"{GenerarLinia(PINZELL, midaLinia)}\n");
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
