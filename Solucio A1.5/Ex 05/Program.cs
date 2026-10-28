namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra quantes lectures hi ha, la mitjana arrodonida a un 
             * decimal, i quantes lectures són perilloses (més de 85 dB).
             */
            const string RUTA = @"soroll.txt";
            const int MARCADEFI = -1;
            string? linia = "";
            int numeroActual = 0, lecturesPerilloses = 0,
                nLectures = 0, total = 0;
            double mitjana = 0;
            StreamReader fitxer = new StreamReader(RUTA);
            linia = fitxer.ReadLine();
            numeroActual = Convert.ToInt32(linia);

            while (numeroActual != MARCADEFI)
            {
                nLectures++;
                if (numeroActual > 85)
                {
                    lecturesPerilloses++;
                }
                total += numeroActual;
                linia = fitxer.ReadLine();
                numeroActual = Convert.ToInt32(linia);
            }
            mitjana = Convert.ToDouble(total) / Convert.ToDouble(nLectures);
            Console.WriteLine($"Lectures: {nLectures}");
            Console.WriteLine($"Mitjana: {mitjana:F1}");
            Console.WriteLine($"Lectures perilloses (més de 85 dB): {lecturesPerilloses}");
            fitxer.Close();
        }
    }
}
