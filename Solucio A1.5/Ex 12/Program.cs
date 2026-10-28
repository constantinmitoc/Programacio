namespace Ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: troba quina va ser la sèrie més llarga de partits seguits
             * sense perdre (guanyats o empatats) del Girona.
             */
            const string RUTA = @"girona_23_24.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            int golG = 0, golV = 0,
                ratxaActual = 0, ratxaMesLlarga = 0;

            while (linia != null)
            {
                linia = fitxer.ReadLine();
                golV = Convert.ToInt32(linia);
                linia = fitxer.ReadLine();
                golG = Convert.ToInt32(linia);

                if (golG > golV || golG == golV)
                {
                    ratxaActual++;
                }
                else
                {
                    ratxaActual = 0;
                }
                if (ratxaActual > ratxaMesLlarga)
                {
                    ratxaMesLlarga = ratxaActual;
                }
            }
            Console.WriteLine($"La ratxa més llarga sense perdre és de {ratxaMesLlarga} partits.");
        }
    }
}
