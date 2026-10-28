namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: compta quants punts són dins de la circumferència, quants
             * són just sobre la circumferència i quants en són fora.
             */
            const string RUTA = @"coordenades.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            double radi = 0, x = 0, y = 0,
                distancia = 0, dintre = 0, 
                fora = 0, eix = 0;

            linia = fitxer.ReadLine();
            radi = Convert.ToInt32(linia);

            while (linia != null)
            {
                linia = fitxer.ReadLine();
                x = Convert.ToDouble(linia);
                linia = fitxer.ReadLine();
                y = Convert.ToDouble(linia);

                distancia = Distancia(x, y);

                if (distancia > radi)
                {
                    fora++;
                }
                else if (distancia < radi)
                {
                    dintre++;
                }
                else
                {
                    eix++;
                }
            }
            Console.WriteLine($"Radi: {radi}");
            Console.WriteLine($"Punts dins: {dintre}");
            Console.WriteLine($"Punts sobre la circumferència: {eix}");
            Console.WriteLine($"Punts fora: {fora}");

            fitxer.Close();
        }
        /// <summary>
        /// Calcula la distancia d'uns punts al origen
        /// </summary>
        /// <param name="x">El punt X</param>
        /// <param name="y">El punt Y</param>
        /// <returns></returns>
        static double Distancia(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
