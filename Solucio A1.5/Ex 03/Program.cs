namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: calcula la mitjana dels números, arrodonida a dos decimals.
             * Si el fitxer fos buit, mostra El fitxer és buit. en lloc de la mitjana.
             */
            const string RUTA = @"numeros2.txt";
            string? liniaActual = "";
            double mitjana = 0;
            int nNumeros = 0, sumaNumeros = 0, numeroActual = 0;

            StreamReader fitxer = new StreamReader(RUTA);
            liniaActual = fitxer.ReadLine();

            if (liniaActual == null)
            {
                Console.WriteLine("El fitxer és buit.");
            }
            else
            {
                while (liniaActual != null)
                {
                    nNumeros++;
                    numeroActual = Convert.ToInt32(liniaActual);
                    sumaNumeros += numeroActual;
                    liniaActual = fitxer.ReadLine();
                }
                mitjana = (Convert.ToDouble(sumaNumeros)) / nNumeros;
                Console.WriteLine($"Números llegits: {nNumeros}");
                Console.WriteLine($"Mitjana: {mitjana:F2}");

                fitxer.Close();
            }
            
        }
    }
}
