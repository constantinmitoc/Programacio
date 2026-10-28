namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: compta quants números són positius, quants negatius i quants zeros.
             */
            const string RUTA = @"numeros.txt";
            string? liniaActual = "";
            int numeroActual = 0, numerosPositius = 0,
                numerosNegatius = 0, numeroDeZeros = 0;

            StreamReader arxiu = new StreamReader(RUTA);
            liniaActual = arxiu.ReadLine();

            while (liniaActual != null)
            {
                numeroActual = Convert.ToInt32(liniaActual);
                if (numeroActual > 0)
                {
                    numerosPositius++;
                }
                else if (numeroActual < 0)
                {
                    numerosNegatius++;
                }
                else
                {
                    numeroDeZeros++;
                }

                liniaActual = arxiu.ReadLine();
            }

            Console.WriteLine($"Positius: {numerosPositius}");
            Console.WriteLine($"Negatius: {numerosNegatius}");
            Console.WriteLine($"Zeros: {numeroDeZeros}");

            arxiu.Close();
        }
    }
}
