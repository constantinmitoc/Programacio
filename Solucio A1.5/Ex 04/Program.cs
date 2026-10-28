namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra el número més gran i el més petit del fitxer.
             */
            const string RUTA = @"numeros.txt";
            string? liniaActual = "";
            int numeroMaxim = 0, numeroMinim = 0,
                numeroActual = 0;
            StreamReader fitxer = new StreamReader(RUTA);

            liniaActual = fitxer.ReadLine();
            numeroActual = Convert.ToInt32(liniaActual);
            numeroMaxim = numeroActual;
            numeroMinim = numeroActual;

            while (liniaActual != null)
            {
                numeroActual = Convert.ToInt32(liniaActual);
                if (numeroActual > numeroMaxim)
                {
                    numeroMaxim = numeroActual;
                }
                if (numeroActual < numeroMinim)
                {
                    numeroMinim = numeroActual;
                }

                liniaActual = fitxer.ReadLine();
                
            }
            Console.WriteLine($"Màxim: {numeroMaxim}");
            Console.WriteLine($"Mínim: {numeroMinim}");

            fitxer.Close();
        }
    }
}
