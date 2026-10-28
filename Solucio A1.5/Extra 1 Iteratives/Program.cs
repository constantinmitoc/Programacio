namespace Extra_1_Iteratives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string RUTA = @"Dades\pluja.txt";
            string? liniaActual;
            int quantitatDePluja = 0, nDiesDePluja = 0, plujaActual = 0;

            StreamReader fitxer = new StreamReader(RUTA);

            liniaActual = fitxer.ReadLine();

            while (liniaActual != null)
            {
                plujaActual = Convert.ToInt32(liniaActual);

                if (plujaActual > 0)
                {
                    quantitatDePluja = quantitatDePluja + plujaActual;
                    nDiesDePluja++;
                }

                liniaActual = fitxer.ReadLine();
            }

            Console.WriteLine($"Ha plogut {nDiesDePluja} dies un " +
                $"total de {quantitatDePluja} litres");
            fitxer.Close();
        }
    }
}
