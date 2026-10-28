namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: compta quants números té el fitxer
             */

            const string RUTA = @"numeros.txt";
            string? liniaActual = "";
            int nNumeros = 0;
            StreamReader fitxer = new StreamReader(RUTA);

            liniaActual = fitxer.ReadLine();

            while (liniaActual != null)
            {
                nNumeros++;
                liniaActual = fitxer.ReadLine();
            }

            Console.WriteLine($"El fitxer té {nNumeros} números.");

            fitxer.Close();
        }
    }
}
