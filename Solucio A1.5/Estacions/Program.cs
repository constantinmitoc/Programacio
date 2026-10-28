namespace Estacions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string RUTA = @"pluja_estacions.txt";
            const int MOLTA_PLUJA = 30;
            int estacionsAmbMoltaPluja = 0;
            string? liniaActual;
            int plujaActual = 0;
            int maxim = Int32.MaxValue;

            StreamReader fitxer = new StreamReader(RUTA);

            liniaActual = fitxer.ReadLine();

            while (liniaActual != null)
            {
                plujaActual = Convert.ToInt32(fitxer.ReadLine());

                if (plujaActual >= MOLTA_PLUJA)
                {
                    Console.WriteLine($"A l'estacio de {liniaActual} han" +
                        $" caigut {plujaActual} litres");
                }

                liniaActual = fitxer.ReadLine();
            }


            fitxer.Close();
        }
    }
}
