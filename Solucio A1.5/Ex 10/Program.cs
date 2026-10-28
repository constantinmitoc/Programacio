namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: compta els partits guanyats, empatats i perduts pel Girona, 
             * i en calcula els punts. Una victòria val 3 punts, un empat 1 i una derrota 0.
             */
            const string RUTA = @"girona_23_24.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            int golG = 0, golV = 0,
                punts = 0, guanyat = 0,
                perdut = 0, empat = 0;

            linia = fitxer.ReadLine();
            golV = Convert.ToInt32(linia);
            linia = fitxer.ReadLine();
            golG = Convert.ToInt32(linia);

            while (linia != null)
            {
                if (golG > golV)
                {
                    guanyat++;
                }
                else if (golG < golV)
                {
                    perdut++;
                }
                else
                {
                    empat++;
                }
                linia = fitxer.ReadLine();
                golV = Convert.ToInt32(linia);
                linia = fitxer.ReadLine();
                golG = Convert.ToInt32(linia);
            }
            punts = guanyat * 3 + empat;

            Console.WriteLine($"Guanyats: {guanyat}");
            Console.WriteLine($"Empatats: {empat}");
            Console.WriteLine($"Perduts: {perdut}");
            Console.WriteLine($"Punts: {punts}");

            fitxer.Close();
        }
    }
}
