namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana el radi d'una circumferència centrada a l'origen (0, 0)
             * i diu, per a cada punt del fitxer, si és dins, sobre o fora de la circumferència.
             */
            const string RUTA = @"coordenades_n.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            linia = fitxer.ReadLine();
            double radi, x, y, distancia;
            int punt;

            Console.Write("Radi de la circumferència: ");
            radi = Convert.ToDouble(Console.ReadLine());
            linia = fitxer.ReadLine();

            for (x = 0, y = 0, distancia = 0, punt = 1;
                linia != null; linia = fitxer.ReadLine(), punt++)
            {
                x = Convert.ToDouble(linia);
                linia = fitxer.ReadLine();
                y = Convert.ToDouble(linia);

                distancia = Distancia(x, y);
                Console.WriteLine($"Punt {punt} ({x}; {y}): {Posicio(distancia, radi)}");
            }
            fitxer.Close();
        }
        /// <summary>
        /// Calcula la distancia d'un punt del orgien
        /// </summary>
        /// <param name="x">La posicio X</param>
        /// <param name="y">La posicio Y</param>
        /// <returns></returns>
        static double Distancia(double x, double y)
        {
            double resultat = 0;

            resultat = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return resultat;
        }
        /// <summary>
        /// Retorna l'estring pertinent a la posicio del punt
        /// </summary>
        /// <param name="distancia">La distancia al punt</param>
        /// <param name="radi">El radi de la circunferencia</param>
        /// <returns></returns>
        static string Posicio(double distancia, double radi)
        {
            string resultat = "";
            
            if (distancia > radi)
            {
                resultat = "fora";
            }
            else if (distancia < radi)
            {
                resultat = "dins";
            }
            else
            {
                resultat = "sobre";
            }

            return resultat;
        }
    }
}
